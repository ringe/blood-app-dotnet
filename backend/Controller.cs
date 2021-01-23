using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasuresController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public MeasuresController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/measuress
        [HttpGet]
        public async Task<ActionResult<List<Measures>>> Get()
        {
            return await _dbContext.Measures.ToListAsync();
        }

        // GET api/measures/{email}
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Measures>> Get(string id)
        {
            return await _dbContext.Measures.FindAsync(id);
        }

        // POST api/measures
        [Authorize]
        [HttpPost]
        public async Task Post(Measures model)
        {
            await _dbContext.AddAsync(model);
            await _dbContext.SaveChangesAsync();
        }

        // PUT api/measures/{email}
        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, Measures model)
        {
            var exists = await _dbContext.Measures.AnyAsync(f => f.Id == id);
            if (!exists)
            {
                return NotFound();
            }

            _dbContext.Measures.Update(model);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}