using System.ComponentModel.DataAnnotations;

namespace ABP.Test.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}