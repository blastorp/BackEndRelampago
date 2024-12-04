using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelampagoP.Data;
using RelampagoP.Models;

namespace RelampagoP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MacroProcesoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MacroProcesoController(ApplicationDbContext db)
        {
            _db = db;

        }

        [HttpGet]
        [Route("listarMacroP")]

        public dynamic listarMacroP()
        {
            try
            {
                IEnumerable<MacroProceso> objProcList = _db.Macroproceso.FromSqlRaw<MacroProceso>("exec sp_Macroproceso_CRUD 'read'");
                return objProcList.ToList();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
