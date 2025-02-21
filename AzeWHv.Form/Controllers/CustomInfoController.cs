using AzeWHV.Data;
using Microsoft.AspNetCore.Mvc;

namespace AzeWHv.Form.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomInfoController : ControllerBase
    {
        private readonly AzeDataContext _context;

        public CustomInfoController(AzeDataContext context)
        {
            _context = context;
        }

        // GET: api/CustomerInfo
        [HttpGet("CustomerInfo")]
        public IActionResult CustomerInfo()
        {
            var test = _context.CustomInfos;
            return Ok(_context.CustomInfos);
        }
        // Post: api/CustomerInfo
        [HttpPost("CustomerInfo")]
        public IActionResult CustomerInfo(CustomInfo customInfo)
        {
            _context.CustomInfos.Add(customInfo);
            _context.SaveChanges();
            var newOne = _context.CustomInfos.Find(customInfo.CustomId);
            return Ok(newOne);
        }

        [HttpGet]
        public IActionResult Get()
        {

            _context.Database.EnsureCreated();
            return Ok(new
            {
                Name = "AzeWHv",
                Description = "AzeWHv is a .NET 8 Web API project for AzeWHv.",
                Version = "1.0.0"
            });
        }
    }
}
