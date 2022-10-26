namespace BookList.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Constants.DataConstants.User;

    public class LoginViewModel
    {
        [Required]
        [Display(Name = UserNameDisplay)]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
