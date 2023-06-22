using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SqlTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly SampleDbContext _context;

        public OrdersController(SampleDbContext context)
        {
            _context = context;
        }
    }
}
