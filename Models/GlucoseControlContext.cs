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

        public DbSet<Scouting> Scoutings { get; set; } = null!;
    }
}