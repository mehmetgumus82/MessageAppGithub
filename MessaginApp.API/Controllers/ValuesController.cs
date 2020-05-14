using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessaginApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MessaginApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;

        }

        // GET api/values
        [HttpGet]
        
        public async Task<IActionResult> Get()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        /*
        public IActionResult Get()
        {
            //throw new Exception("Test Exception");
            var values = _context.Values.ToList();
            //var values = _context.Values.Where(x=>x.Id%2==1).ToList();
            return Ok(values); //new string[] { "value1", "value2" };
        }
        */

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(value);
        }

        /*
        public ActionResult<string> Get(int id)
        {
            //return "value";
            var value = _context.Values.FirstOrDefault(x=>x.Id==id);
            return Ok(value);
        }
        */

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
