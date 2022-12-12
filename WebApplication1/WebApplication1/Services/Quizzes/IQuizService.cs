using QuizSystem.Services.Quizzes.Models;
using WebApplication1.Data;

namespace QuizSystem.Services.Quizzes
{
    public interface IQuizService
    {
        List<QuizQueryServiceModel> All();
    }
}
