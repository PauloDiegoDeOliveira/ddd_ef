using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModes
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O email não pode vazio.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha não pode vazio.")]
        public string Password { get; set; }
    }
}