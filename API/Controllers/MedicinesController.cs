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
    public class MedicinesController : ControllerBase
    {
        private readonly MedicinesService _medicinesService;

        public MedicinesController(MedicinesService medicinesService) => 
            _medicinesService = medicinesService;

        // GET: api/Medicines
        [HttpGet]
        public async Task<List<Medicine>> GetMedicines()
        {
            return await _medicinesService.GetAsync();
        }

        // GET: api/Medicines/5
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Medicine>> GetMedicine(string id)
        {
            var medicine = await _medicinesService.GetAsync(id);

            if (medicine is null)
            {
                return NotFound();
            }

            return medicine;
        }

        // PUT: api/Medicines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> PutMedicine(string id, Medicine updatedMedicine)
        {
            var medicine = await _medicinesService.GetAsync(id);

            if (medicine is null)
            {
                return NotFound();
            }

            updatedMedicine.Id = medicine.Id;

            await _medicinesService.UpdateAsync(id, updatedMedicine);

            return NoContent();
        }

        // POST: api/Medicines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("id:length(24)")]
        public async Task<IActionResult> PostMedicine(Medicine medicine)
        {
            await _medicinesService.CreateAsync(medicine);

            return CreatedAtAction(nameof(GetMedicine), new { id = medicine.Id }, medicine);
        }

        // DELETE: api/Medicines/5
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeleteMedicine(string id)
        {
            var medicine = await _medicinesService.GetAsync(id);

            if (medicine == null)
            {
                return NotFound();
            }

            await _medicinesService.RemoveAsync(medicine.Id);

            return NoContent();
        }
    }
}
