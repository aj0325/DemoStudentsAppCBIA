using Demo.Api.Data;
using Demo.Api.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly DemoDbContext _demoDbContext;

        public QuestionsController(DemoDbContext demoDbContext) => _demoDbContext = demoDbContext;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> Get()
        {
            return await _demoDbContext.Questions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetById(int id)
        {
            var question = await _demoDbContext.Questions.FindAsync(id);
            if (question == null)
                return NotFound();

            return question;
        }

        [HttpPost]
        public async Task<ActionResult<Question>> Create(Question question)
        {
            _demoDbContext.Questions.Add(question);
            await _demoDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = question.Id }, question);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Question question)
        {
            if (id != question.Id)
                return BadRequest();

            _demoDbContext.Entry(question).State = EntityState.Modified;

            try
            {
                await _demoDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var question = await _demoDbContext.Questions.FindAsync(id);
            if (question == null)
                return NotFound();

            _demoDbContext.Questions.Remove(question);
            await _demoDbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool QuestionExists(int id)
        {
            return _demoDbContext.Questions.Any(e => e.Id == id);
        }
    }
}
