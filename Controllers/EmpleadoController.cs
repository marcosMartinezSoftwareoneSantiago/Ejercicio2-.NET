using Ejercicio2_10_01_23.Config;
using Ejercicio2_10_01_23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio2_10_01_23.Controllers
{
    [Route("/empleados")]
    public class EmpleadoController : Controller
    {
        private readonly DbEmpresaContext _context;

        public EmpleadoController(DbEmpresaContext context)
        {
            _context = context;
        }
        [HttpGet("listar")]
        public async Task<ActionResult<List<Empleado>>>EmpleadosCompleteList()
        {
            return await _context.empleados.ToListAsync();
        }

        [HttpPost("guardar")]
        public async Task<ActionResult> GuardarEmpleado(Empleado empleado)
        {
            _context.Add(empleado);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
