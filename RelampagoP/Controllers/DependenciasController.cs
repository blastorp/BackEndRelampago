using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelampagoP.Data;
using RelampagoP.Models;

namespace RelampagoP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DependenciasController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DependenciasController(ApplicationDbContext db)
        {
            _db = db;

        }
        [HttpGet]
        [Route("listarDependencias")]

        public dynamic listarDependencias()
        {
            try
            {
                IEnumerable<Dependencias> objProcList = _db.Dependencia.FromSqlRaw<Dependencias>("exec sp_Dependencia_CRUD 'read'");
                return objProcList.ToList();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
