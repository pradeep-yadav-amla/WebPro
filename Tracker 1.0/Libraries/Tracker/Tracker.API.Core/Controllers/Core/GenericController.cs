using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracker.API.Core.Controllers.Core
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController : ControllerBase
    {
/*
        readonly private IDBContext _context;


        //Returns an IQueryable instance for access to entities of the given type in the context
        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities.AsNoTracking();
            }
        }


        //Returns a DbSet instance for access to entities of the given type in the context
        protected virtual DbSet<T> Entities
        {
            get
            {
                return !Equals(_context, null) ? _context.Set<T>() : null;
            }
        }*/

        // GET: api/<GenericController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GenericController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GenericController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GenericController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenericController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
