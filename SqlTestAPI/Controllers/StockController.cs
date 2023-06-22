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
    public class StockController:ControllerBase
    {
        private readonly SampleDbContext _context;

        public StockController(SampleDbContext context)
        {
            _context = context;
        }
    }
}
