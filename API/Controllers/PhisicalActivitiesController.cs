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
    public class PhysicalActivitiesController : ControllerBase
    {
        private readonly PhysicalActivitiesService _physicalActivitiesService;

        public PhysicalActivitiesController(PhysicalActivitiesService physicalActivitiesService) => 
            _physicalActivitiesService = physicalActivitiesService;

        // GET: api/PhysicalActivities
        [HttpGet]
        public async Task<List<PhysicalActivity>> GetPhysicalActivities()
        {
            return await _physicalActivitiesService.GetAsync();
        }

        // GET: api/PhysicalActivities/5
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<PhysicalActivity>> GetPhysicalActivity(string id)
        {
            var physicalActivity = await _physicalActivitiesService.GetAsync(id);

            if (physicalActivity is null)
            {
                return NotFound();
            }

            return physicalActivity;
        }

        // PUT: api/PhysicalActivities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> PutPhysicalActivity(string id, PhysicalActivity updatedPhysicalActivity)
        {
            var physicalActivity = await _physicalActivitiesService.GetAsync(id);

            if (physicalActivity is null)
            {
                return NotFound();
            }

            updatedPhysicalActivity.Id = physicalActivity.Id;

            await _physicalActivitiesService.UpdateAsync(id, updatedPhysicalActivity);

            return NoContent();
        }

        // POST: api/PhysicalActivities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("id:length(24)")]
        public async Task<IActionResult> PostPhysicalActivity(PhysicalActivity physicalActivity)
        {
            await _physicalActivitiesService.CreateAsync(physicalActivity);

            return CreatedAtAction(nameof(GetPhysicalActivity), new { id = physicalActivity.Id }, physicalActivity);
        }

        // DELETE: api/PhysicalActivities/5
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeletePhysicalActivity(string id)
        {
            var physicalActivity = await _physicalActivitiesService.GetAsync(id);

            if (physicalActivity == null)
            {
                return NotFound();
            }

            await _physicalActivitiesService.RemoveAsync(physicalActivity.Id);

            return NoContent();
        }
    }
}
