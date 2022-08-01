using System.ComponentModel.DataAnnotations;

namespace EscolaOnline.Api.ViewModels
{
    public class StudentViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string PasswordHash { get; set; }
    }
}
