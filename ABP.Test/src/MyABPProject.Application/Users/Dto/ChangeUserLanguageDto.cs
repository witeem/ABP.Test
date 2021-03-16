using System.ComponentModel.DataAnnotations;

namespace MyABPProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}