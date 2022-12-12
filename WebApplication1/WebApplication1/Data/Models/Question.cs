using System.ComponentModel.DataAnnotations;
using static QuizSystem.Data.DataConstants.Question;

namespace QuizSystem.Data.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string? Title { get; set; }

        [Required]
        public List<Answer>? Answers { get; set; }

        [Range(1, 10)]
        public int Points { get; set; }
    }
}
