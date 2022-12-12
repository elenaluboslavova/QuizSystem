using QuizSystem.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace QuizSystem.Services.Quizzes.Models
{
    public class QuizQueryServiceModel
    {
        public string Title { get; set; }

        public List<Question>? Questions { get; set; }

        public int TotalPoints { get; set; }

        public int Difficulty { get; set; }

        public DateTime DateCreated { get; set; }

        public string CategoryName { get; set; }
    }
}
