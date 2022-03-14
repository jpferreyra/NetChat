using Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelsController : ControllerBase
    {
        private readonly DataContext _context;

        public ChannelsController(DataContext dataContext)
        {
            _context = dataContext ?? throw new ArgumentException(nameof(dataContext));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var channel = await _context.Channels.ToListAsync();
            return Ok(channel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _context.Channels.FirstOrDefaultAsync(x => x.Id == id));
        }
    }
}
