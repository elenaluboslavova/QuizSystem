using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizSystem.Data.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Answer>? Answers { get; set; }

        public DbSet<Question>? Questions { get; set; }

        public DbSet<Category>? Categories { get; set; }

        public DbSet<Quiz>? Quizzes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Quiz>()
                .HasOne(q => q.Category)
                .WithMany(q => q.Quizzes)
                .HasForeignKey(q => q.CategoryId)
                .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}