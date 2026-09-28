using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace Janja_V2.Models
{
    public class Processo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O número do processo é obrigatório.")]
        [StringLength(200, ErrorMessage = "O número deve ter no máximo 200 caracteres.")]
        public string? Numero { get; set; } = string.Empty;

        [Required(ErrorMessage = "O interessado do processo é obrigatório.")]
        [StringLength(200, ErrorMessage = "O interessado do processo deve ter no máximo 200 caracteres.")]
        public string? Interessado { get; set; } = string.Empty;

        [Required(ErrorMessage = "O assunto do processo é obrigatório.")]
        [StringLength(300, ErrorMessage = "O assunto do processo deve ter no máximo 200 caracteres.")]
        public string? Assunto { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição do processo é obrigatória.")]
        [StringLength(2000, ErrorMessage = "A descrição do processo deve ter no máximo 200 caracteres.")]
        public string? Descricao {  get; set; } = string.Empty;

        [Required(ErrorMessage = "A situação do processo é obrigatória.")]
        [StringLength(50, ErrorMessage = "A situação do processo deve ter no máximo 50 caracteres.")]
        public string? Situacao {  get; set; } = "Aberto";
        
    }
}