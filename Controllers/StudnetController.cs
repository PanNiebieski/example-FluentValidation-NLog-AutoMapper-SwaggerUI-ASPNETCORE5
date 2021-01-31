using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AddingStuffAndChecking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudnetController : Controller
    {
        /// <summary>
        /// Pobiera listę studentów
        /// </summary>
        /// <returns>Zwraca liste studentów</returns>
        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return GetStudents();
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return GetStudents().Find(e => e.Id == id);
        }

        /// <summary>
        /// Dodaje studenta
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST api/Student
        ///     {
        ///       "firstName": "Jacek",
        ///       "lastName": "Stefaniuk",
        ///       "emailId": "Jacek.Stefaniuk@gmail.com"
        ///     }
        /// </remarks>
        /// response code="201">Zwraca nowego studenta/response>
        /// <response code="400">Jeśli był przesłany NULL</response>
        /// <response code="500">Coś poszło nie tak</response>
        // POST: api/Student
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public Student Post([FromBody] Student Student)
        {
            if (Student == null)
            {
                this.HttpContext.Response.StatusCode = 400;
                return null;
            }

            return new Student();
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student Student)
        {
            // Logic to update an Student
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<Student> GetStudents()
        {
            return new List<Student>()
        {
            new Student()
            {
                Id = 1,
                FirstName= "Jax",
                LastName = "Brighth",
            },
            new Student()
            {
                Id = 2,
                FirstName= "Johny",
                LastName = "Cage",
            }
        };
        }
    }




    public class Student
    {
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
    }
}
