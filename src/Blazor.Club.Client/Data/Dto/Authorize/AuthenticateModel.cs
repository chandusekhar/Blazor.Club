using System.ComponentModel.DataAnnotations;

namespace Blazor.Club.Data.Dto.Authorize
{
    public class AuthenticateModel
    {
        [Required]
        [StringLength(256)]
        public string UserNameOrEmailAddress { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        public bool RememberClient { get; set; }
    }
}