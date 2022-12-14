using FinanceWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FinanceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public AppDBContext _context { get;}

        public UserController(AppDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method returns all users' details present in database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var UserList = _context.Users.ToList();
            return Ok(UserList);
        }

        /// <summary>
        /// This method returns user details by userId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id}")]
        [HttpGet]
        public ActionResult Get(int id) {
            var user = _context.Users.FirstOrDefault(c => c.userId == id);
            return Ok(user);
        }

        /// <summary>
        /// This method adds new user details to the database
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();

            return CreatedAtAction("Get", new { id = newUser.userId }, newUser);
        }

        /// <summary>
        /// This method modifies user details by using userId
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modifiedUser"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult Put(int id, User modifiedUser)
        {
            var data = _context.Users.FirstOrDefault(c => c.userId == id);
            if (data == null)
                return BadRequest();
            else
            {
                data.name = modifiedUser.name;
                _context.SaveChanges();
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var data = _context.Users.FirstOrDefault(c => c.userId == id);
            if (data == null)
                return NotFound();
            else
            {
                _context.Users.Remove(data);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
