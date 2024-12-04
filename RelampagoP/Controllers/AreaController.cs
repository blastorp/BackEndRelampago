using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelampagoP.Data;
using RelampagoP.Models;

namespace RelampagoP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AreaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AreaController(ApplicationDbContext db)
        {
            _db = db;

        }
        [HttpGet]
        [Route("listarAreas")]

        public dynamic listarAreas()
        {
            try
            {
                IEnumerable<Area> objProcList = _db.Area.FromSqlRaw<Area>("exec sp_Area_CRUD 'read'");
                return objProcList.ToList();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
