using Ejercicio2_10_01_23.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio2_10_01_23.Config
{
    public class DbEmpresaContext : DbContext
    {
        public DbEmpresaContext(DbContextOptions<DbEmpresaContext> options) : base(options) { }

        public DbSet<Empleado> empleados { get; set; }
    }
}
