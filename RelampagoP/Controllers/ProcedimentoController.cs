using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using RelampagoP.Models;
using RelampagoP.Data;


namespace RelampagoP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcedimentoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ProcedimentoController(ApplicationDbContext db)
        {
            _db = db;

        }

        [HttpGet]
        [Route("listarProcedimientos")]

        public dynamic listarProcedimientos()
        {
            try
            {
                IEnumerable<Procedimiento> objProcList = _db.Procedimiento.FromSqlRaw<Procedimiento>("exec [sp_Procedimiento_CRUD] 'REad'");
                return objProcList.ToList();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


    }
}
