using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheNicestWebApp.Data;
using TheNicestWebApp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheNicestWebApp.API
{
    [Route("api/[controller]")]
    public class SignupController : Controller
    {
        public ApplicationDbContext _db;

        public SignupController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _db.Persons.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _db.Persons.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound(); 
            }
            return Ok(person);
                
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }
            if (person.Id == 0)

            {
                _db.Persons.Add(person);
                _db.SaveChanges();
            }
            else
            {
                var original = _db.Persons.FirstOrDefault(j => j.Id == j.Id);
                original.FirstName = person.FirstName;
                original.LastName = person.LastName;
                original.Description = person.Description;
                original.Title = person.Title;
                _db.SaveChanges();
            }
            return Ok(person);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
