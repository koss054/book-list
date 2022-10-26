namespace BookList.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Data.Entities;

    using static Constants.DataConstants.User;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserBook>()
                .HasKey(ub => new { ub.UserId, ub.BookId });

            builder.Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(MaxUserNameLength)
                .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(MaxEmailLength)
                .IsRequired();

            base.OnModelCreating(builder);
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}