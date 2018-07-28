using System.ComponentModel.DataAnnotations;

namespace SocialApp.API.Dtos
{
    public class UserRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength=3,ErrorMessage="You must specify password between 3 and 8 character")]
        public string Password { get; set; }
    }
}