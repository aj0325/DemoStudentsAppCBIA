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
    public class CulturalEventController : ControllerBase
    {
        private readonly DemoDbContext _demoDbContext;

        public CulturalEventController(DemoDbContext demoDbContext) => _demoDbContext = demoDbContext;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CulturalEvent>>> Get()
        {
            return await _demoDbContext.CulturalEvents.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CulturalEvent>> GetById(int id)
        {
            var culturalEvent = await _demoDbContext.CulturalEvents.FindAsync(id);
            if (culturalEvent == null)
                return NotFound();

            return culturalEvent;
        }

        [HttpPost]
        public async Task<ActionResult<CulturalEvent>> Create(CulturalEvent culturalEvent)
        {
            _demoDbContext.CulturalEvents.Add(culturalEvent);
            await _demoDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = culturalEvent.Id }, culturalEvent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CulturalEvent culturalEvent)
        {
            if (id != culturalEvent.Id)
                return BadRequest();

            _demoDbContext.Entry(culturalEvent).State = EntityState.Modified;

            try
            {
                await _demoDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CulturalEventExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var culturalEvent = await _demoDbContext.CulturalEvents.FindAsync(id);
            if (culturalEvent == null)
                return NotFound();

            _demoDbContext.CulturalEvents.Remove(culturalEvent);
            await _demoDbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool CulturalEventExists(int id)
        {
            return _demoDbContext.CulturalEvents.Any(e => e.Id == id);
        }
    }
}
