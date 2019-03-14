namespace NewsletterInfo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NewsletterContext : DbContext
    {
        public NewsletterContext()
            : base("name=NewsletterContext")
        {
        }

        public virtual DbSet<SignUp> SignUps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SignUp>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<SignUp>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<SignUp>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);
        }
    }
}
