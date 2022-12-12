using System.ComponentModel.DataAnnotations;
using static QuizSystem.Data.DataConstants.Answer;

namespace QuizSystem.Data.Models
{
    public class Answer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string? Title { get; set; }

        public bool IsRight { get; set; }
    }
}
