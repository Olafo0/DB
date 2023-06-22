using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController:ControllerBase
    {
        private readonly SampleDbContext _context;

        public EmployeesController(SampleDbContext _context)
        {
            this._context = _context;
        }
        [HttpGet]
        public IActionResult Test()
        {
            return null;
        }

    }
}
