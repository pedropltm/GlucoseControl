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
    public class MealsController : ControllerBase
    {
        private readonly MealsService _mealsService;

        public MealsController(MealsService mealsService)
        {
            _mealsService = mealsService;
        }

        // GET: api/Meals
        [HttpGet]
        public async Task<List<Meal>> GetMeals() => await _mealsService.GetAsync();

        // GET: api/Meals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meal>> GetMeal(long id)
        {
            var meal = await _mealsService.GetAsync(id);

            if (meal == null)
            {
                return NotFound();
            }

            return meal;
        }

        // PUT: api/Meals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeal(long id, Meal updatedMeal)
        {
            var meal = await _mealsService.GetAsync(id);

            if (meal is null)
            {
                return NotFound();
            }

            updatedMeal.Id = meal.Id;

            await _mealsService.UpdateAsync(id, updatedMeal);

            return NoContent();
        }

        // POST: api/Meals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostMeal(Meal meal)
        {
            await _mealsService.CreateAsync(meal);

            return CreatedAtAction(nameof(GetMeal), new { id = meal.Id }, meal);
        }

        // DELETE: api/Meals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeal(long id)
        {
            var meal = await _mealsService.GetAsync(id);

            if (meal == null)
            {
                return NotFound();
            }

            await _mealsService.RemoveAsync(meal.Id);

            return NoContent();
        }
    }
}
