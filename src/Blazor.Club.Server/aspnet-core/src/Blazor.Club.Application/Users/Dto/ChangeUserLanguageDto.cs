using System.ComponentModel.DataAnnotations;

namespace Blazor.Club.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}