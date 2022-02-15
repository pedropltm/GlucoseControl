#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GlucoseControl.Models;
using GlucoseControl.Services;

namespace GlucoseControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoutingsController : ControllerBase
    {
        private readonly ScoutingsService _scoutingsService;

        public ScoutingsController(ScoutingsService scoutingsService) => 
            _scoutingsService = scoutingsService;

        // GET: api/Scoutings
        [HttpGet]
        public async Task<List<Scouting>> GetScoutings()
        {
            return await _scoutingsService.GetAsync();
        }

        // GET: api/Scoutings/5
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Scouting>> GetScouting(string id)
        {
            var scouting = await _scoutingsService.GetAsync(id);

            if (scouting is null)
            {
                return NotFound();
            }

            return scouting;
        }

        // PUT: api/Scoutings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> PutScouting(string id, Scouting updatedScouting)
        {
            var scouting = await _scoutingsService.GetAsync(id);

            if (scouting is null)
            {
                return NotFound();
            }

            updatedScouting.Id = scouting.Id;

            await _scoutingsService.UpdateAsync(id, updatedScouting);

            return NoContent();
        }

        // POST: api/Scoutings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("id:length(24)")]
        public async Task<IActionResult> PostScouting(Scouting scouting)
        {
            await _scoutingsService.CreateAsync(scouting);

            return CreatedAtAction(nameof(GetScouting), new { id = scouting.Id }, scouting);
        }

        // DELETE: api/Scoutings/5
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeleteScouting(string id)
        {
            var scouting = await _scoutingsService.GetAsync(id);

            if (scouting == null)
            {
                return NotFound();
            }

            await _scoutingsService.RemoveAsync(scouting.Id);

            return NoContent();
        }
    }
}
