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
    }
}
