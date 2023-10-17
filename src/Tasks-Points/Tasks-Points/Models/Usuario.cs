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
        public string Name { get; set; }

        [Required(ErrorMessage = "É necessário informar um email válido para o usuário")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário informar uma senha para o usuário")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public Permission Permission { get; set; }

    }

    public enum Permission
    {
        Admin, 
        User
    }
}
