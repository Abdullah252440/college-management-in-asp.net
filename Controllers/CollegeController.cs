using coolege_management.dto;
using coolege_management.Entity;
using coolege_management.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace coolege_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly collegeDBContext _context;
        public CollegeController(collegeDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("get-college")]

        public async Task<ActionResult> GetCollege()
        {
            if (_context.CollegeNames == null)
            {
                return NotFound();
            }
            return Ok(await _context.CollegeNames.ToListAsync());

        }
        [HttpGet]
        [Route("addition")]
        public int Addition()
        {
            ValueData o = new ValueData();
            o.FirstValue = 30;
            o.SecondValue = 30;
            return o.FirstValue + o.SecondValue;









        }

    }
}
