using Empleados.Models;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Data
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet <Empleado> Empleados { get; set; }

    }
}
