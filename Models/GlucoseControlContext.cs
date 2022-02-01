using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace GlucoseControl.Models
{
    public class GlucoseControlContext : DbContext
    {
        public GlucoseControlContext(DbContextOptions<GlucoseControlContext> options)
            : base(options)
        {
        }

        public DbSet<Meal> Meals { get; set; } = null!;
        public DbSet<Medicine> Medicines { get; set; } = null!;        
    }
}