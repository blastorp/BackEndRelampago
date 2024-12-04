using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelampagoP.Data;
using RelampagoP.Models;

namespace RelampagoP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EjeController : Controller
    {

        private readonly ApplicationDbContext _db;

        public EjeController(ApplicationDbContext db)
        {
            _db = db;

        }
        [HttpGet]
        [Route("listarEjes")]

        public dynamic listarEjes()
        {
            try
            {
                IEnumerable<Eje> objProcList = _db.Eje.FromSqlRaw<Eje>("exec sp_eje_crud 'read'");
                return objProcList.ToList();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
