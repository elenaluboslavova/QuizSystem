using System.ComponentModel.DataAnnotations;
using static QuizSystem.Data.DataConstants.Quiz;

namespace QuizSystem.Data.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string? Title { get; set; }

        public List<Question>? Questions { get; set; }

        public int TotalPoints { get; set; }

        [Range(1, 10)]
        public int Difficulty { get; set; }

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; init; }
    }
}
