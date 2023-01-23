using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProvaBackEndFelipeB.Models
{
    public class Credencials
    {
        [Column("user")]
        [Display(Name = "Usuário")]
        private string userName { get; set; }

        [Column("password")]
        [Display(Name = "Senha")]
        private int Password { get; set; }
    }
}
