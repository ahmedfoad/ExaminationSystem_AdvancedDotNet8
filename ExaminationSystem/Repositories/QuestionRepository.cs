using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly Context _context;
        public QuestionRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Question>> GetAll()
        {
           return await _context.Questions.ToListAsync();
        }
    }

    public interface IQuestionRepository
    {
        Task<IEnumerable<Question>> GetAll();
    }
}
