#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GlucoseControl.Models;

namespace GlucoseControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoutingsController : ControllerBase
    {
        private readonly GlucoseControlContext _context;

        public ScoutingsController(GlucoseControlContext context)
        {
            _context = context;
        }

        // GET: api/Scoutings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scouting>>> GetScoutings()
        {
            return await _context.Scoutings.ToListAsync();
        }

        // GET: api/Scoutings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Scouting>> GetScouting(long id)
        {
            var scouting = await _context.Scoutings.FindAsync(id);

            if (scouting == null)
            {
                return NotFound();
            }

            return scouting;
        }

        // PUT: api/Scoutings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScouting(long id, Scouting scouting)
        {
            if (id != scouting.Id)
            {
                return BadRequest();
            }

            _context.Entry(scouting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoutingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Scoutings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Scouting>> PostScouting(Scouting scouting)
        {
            _context.Scoutings.Add(scouting);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScouting", new { id = scouting.Id }, scouting);
        }

        // DELETE: api/Scoutings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScouting(long id)
        {
            var scouting = await _context.Scoutings.FindAsync(id);
            if (scouting == null)
            {
                return NotFound();
            }

            _context.Scoutings.Remove(scouting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScoutingExists(long id)
        {
            return _context.Scoutings.Any(e => e.Id == id);
        }
    }
}
