using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite o Nome do Contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o E-mail do Contato")]
        [EmailAddress(ErrorMessage = "O email informado não é valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o Celular do Contato")]
        [Phone(ErrorMessage = "O celular informado não é valido")]
        public string Celular { get; set; }
    }
}
