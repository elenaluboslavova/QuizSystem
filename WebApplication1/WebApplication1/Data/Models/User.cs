using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static QuizSystem.Data.DataConstants.User;

namespace QuizSystem.Data.Models
{
    public class User : IdentityUser
    {
        [MaxLength(FirstNameMaxLength)]
        public string? FirstName { get; set; }

        [MaxLength(LastNameMaxLength)]
        public string? LastName { get; set; }

        public List<Quiz>? CreatedQuizzes { get; set; }

        public List<Quiz>? SolvedQuizzes { get; set; }

        public int TotalPoints { get; set; }
    }
}
