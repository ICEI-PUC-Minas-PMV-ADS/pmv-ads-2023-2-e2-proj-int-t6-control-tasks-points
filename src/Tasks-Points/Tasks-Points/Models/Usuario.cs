using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tasks_Points.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário informar o nome do usuário")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "É necessário informar um email válido")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário informar uma senha válida")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Permissão")]
        public Permission Permission { get; set; }

    }

    public enum Permission
    {
        Admin, 
        User
    }
}
