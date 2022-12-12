using AutoMapper;
using AutoMapper.QueryableExtensions;
using QuizSystem.Services.Quizzes.Models;
using WebApplication1.Data;

namespace QuizSystem.Services.Quizzes
{
    public class QuizService : IQuizService
    {
        private readonly ApplicationDbContext data;
        private readonly AutoMapper.IConfigurationProvider mapper;

        public QuizService(ApplicationDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = (AutoMapper.IConfigurationProvider?)mapper;
        }

        public List<QuizQueryServiceModel> All()
        {
            var quizzesQuery = this.data.Quizzes;

            return quizzesQuery.ProjectTo<QuizQueryServiceModel>(this.mapper).ToList();
        }
    }
}
