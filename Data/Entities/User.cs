namespace BookList.Data.Entities
{
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public virtual ICollection<UserBook> UsersBooks { get; set; } = new List<UserBook>();
    }
}
