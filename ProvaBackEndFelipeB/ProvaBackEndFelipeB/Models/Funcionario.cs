using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaBackEndFelipeB.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("email")]
        [Display(Name = "E-Mail")]
        public string email { get; set; }

        [Column("cargo")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }
    }
}
