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
    [Route("api/Patients")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly PatientsService _patientsService;

        public PatientsController(PatientsService patientsService) => 
            _patientsService = patientsService;

        // GET: api/Patients
        [HttpGet]
        public async Task<List<Patient>> GetPatients()
        {
            return await _patientsService.GetAsync();
        }

        // GET: api/Patients/5
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Patient>> GetPatient(string id)
        {
            var patient = await _patientsService.GetAsync(id);

            if (patient is null)
            {
                return NotFound();
            }

            return patient;
        }

        // PUT: api/Patients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> PutPatient(string id, Patient updatedPatient)
        {
            var patient = await _patientsService.GetAsync(id);

            if (patient is null)
            {
                return NotFound();
            }

            updatedPatient.Id = patient.Id;

            await _patientsService.UpdateAsync(id, updatedPatient);

            return NoContent();
        }

        // POST: api/Patients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostPatient(Patient patient)
        {
            await _patientsService.CreateAsync(patient);

            return CreatedAtAction(nameof(GetPatient), new { id = patient.Id }, patient);
        }

        // DELETE: api/Patients/5
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeletePatient(string id)
        {
            var patient = await _patientsService.GetAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            await _patientsService.RemoveAsync(patient.Id);

            return NoContent();
        }
    }
}
