using ExaminationSystem.Data;
using ExaminationSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionRepository _iQuestionRepository;

        public QuestionsController(IQuestionRepository iQuestionRepository)
        {
            _iQuestionRepository = iQuestionRepository;
        }

        //private readonly Context _context;
        //public QuestionsController(Context context)
        //{
        //    _context = context;
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllAsycAsync()
        {
            return Ok(await _iQuestionRepository.GetAll());
        }
    }
}
