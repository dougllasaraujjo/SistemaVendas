using System;
using System.ComponentModel.DataAnnotations;

namespace SisVendas.Models
{
    public class Usuario : BaseModel
    {
        public Usuario()
        {
        }

        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome { get; set; }

        [StringLength(20)]
        public string Sobrenome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(60)]
        public string Email { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public bool NivelAcesso { get; set; }
    }
}
