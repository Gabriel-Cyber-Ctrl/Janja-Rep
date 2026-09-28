using Janja_V2.Configs;
using Janja_V2.Models;

namespace Janja_V2.DAO
{
    public class ProcessoDAO
    {
        private readonly Conexao _conexao;
        
        public ProcessoDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

        public List<Processo> Listar()
        {
            try
            {
                
                var lista = new List<Processo>();
                
                //Buscando e abrindo a conexão com o banco de dados
                using var con = _conexao.GetConnection();

                string sql = "SELECT * FROM processos";
                using var comando = con.CreateCommand();
                comando.CommandText = sql;

                using var leitor = comando.ExecuteReader();

                while(leitor.Read())
                {
                    var processo = new Processo();
                    processo.Id = leitor.GetInt32("id_pro");
                    processo.Numero = leitor.IsDBNull(leitor.GetOrdinal("numero_pro")) ? null : leitor.GetString("numero_pro");
                    processo.Interessado = leitor.GetString("interessado_pro");
                    processo.Assunto = leitor.GetString("assunto_pro");
                    processo.Descricao = leitor.GetString("descricao_pro");
                    processo.Situacao = leitor.GetString("situacao_pro");
                
                    lista.Add(processo);
                }
                
                return lista;
            } catch
            {
                throw;
            }

        }

        public void Inserir(Processo processo)
        {
            using var con = _conexao.GetConnection();


            try{
            string sql = @"Insert into processos (numero_pro, interessado_pro, assunto_pro, descricao_pro, situacao_pro) 
                VALUES (@numero, @interessado, @assunto, @descricao, @situacao)";
                using var comando = con.CreateCommand();
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@numero", processo.Numero);
                comando.Parameters.AddWithValue("@interessado", processo.Interessado);
                comando.Parameters.AddWithValue("@assunto", processo.Assunto);
                comando.Parameters.AddWithValue("@descricao", processo.Descricao);
                comando.Parameters.AddWithValue("@situacao", processo.Situacao);

                comando.ExecuteNonQuery();
            } catch
            {
                throw;
            }
        }

        public void Delete(Processo processo)
        {
            using var con = _conexao.GetConnection();

            try
            {
                string sql = "DELETE FROM processos WHERE id_pro = @id";
                using var comando = con.CreateCommand();
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@id", processo.Id);

                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public void Edit(Processo processo)
        {
            using var con = _conexao.GetConnection();

            try{
                string sql = @"UPDATE processos 
                SET numero_pro = @numero, interessado_pro = @interessado, assunto_pro = @assunto, descricao_pro = @descricao, situacao_pro = @situacao WHERE id_pro = @id";
                using var comando = con.CreateCommand();
                comando.CommandText = sql;

                comando.Parameters.AddWithValue("@id", processo.Id);

                comando.ExecuteNonQuery();
            }
        }

    }
}
