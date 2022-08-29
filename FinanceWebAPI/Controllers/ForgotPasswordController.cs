using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        public ForgotPasswordController(AppDBContext context)
        {
            _context = context;//public property, will be responsible to do crud operations
        }
        public AppDBContext _context { get; }

        [Route("{id}")]
        public ActionResult Put(int id, string newpassword)
        {
            newpassword = "pass@userkk";
            LoginDetail data = _context.LoginDetails.FirstOrDefault(p => p.loginId == id);
            if (data == null)
                return BadRequest();
            else
            {
                data.password = newpassword;
                data.confirmPassword = newpassword;
                _context.LoginDetails.Update(data);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}