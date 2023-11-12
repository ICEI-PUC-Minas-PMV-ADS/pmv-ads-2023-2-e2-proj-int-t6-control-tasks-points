using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tasks_Points.Models
{
    [Table("Recompensas")]
    public class Recompensa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do produto/recompensa!")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para a recompensa.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite o valor desta recompensa em coins.")]
        [Display(Name = "Valor(Coins)")]
        public int Valor { get; set; }
    }
}
