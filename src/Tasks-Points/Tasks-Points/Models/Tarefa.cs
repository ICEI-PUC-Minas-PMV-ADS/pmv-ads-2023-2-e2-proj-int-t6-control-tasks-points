using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tasks_Points.Models
{
    [Table("Tarefas")]
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome da tarefa!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o grau de prioridade!")]
        public GrauPrioridade Prioridade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o responsável pela tarefa!")]
        [Display(Name = "Responsável")]
        public string Responsavel { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o prazo limite para conclusão da tarefa!")]
        [Display(Name = "Prazo Limite (Conclusão)")]
        public DateTime PrazoLimite { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade de coins a ser ganha pela tarefa!")]
        public int Coins { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o status da tarefa!")]
        public StatusTarefa Status { get; set; }
    }

    public enum GrauPrioridade
    {
        Alta, 
        Média,
        Baixa
    }

    public enum StatusTarefa
    {
        Pendente,
        Concluída
    }
}
