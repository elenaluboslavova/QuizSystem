using System.ComponentModel.DataAnnotations;
using static QuizSystem.Data.DataConstants.Category;

namespace QuizSystem.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string? Name { get; set; }

        public List<Quiz>? Quizzes { get; set; }
    }
}
