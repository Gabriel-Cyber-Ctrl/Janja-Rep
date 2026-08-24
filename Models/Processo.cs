using Microsoft.AspNetCore.Http.HttpResults;

namespace Janja_V2.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public string Numero { get; set; } = string.Empty;
        public DateOnly Data {  get; set; }
        public string Interessado { get; set; } = string.Empty;
        public string Assunto { get; set; } = string.Empty;
        public string Descricao {  get; set; } = string.Empty;
        public string Situacao {  get; set; } = string.Empty;
        
    }
}

//create table processos (
//	id_pro INT NOT NULL AUTO_INCREMENT,
//    numero_pro VARCHAR(200) NOT NULL,
//    interessado_pro VARCHAR(200) NOT NULL,
//    assunto_pro VARCHAR(300) NOT NULL,
//    descricao_pro TEXT NOT NULL,
//    situacao_pro VARCHAR(50) NOT NULL default "Aberto",

//    PRIMARY KEY(id_pro)
//);
