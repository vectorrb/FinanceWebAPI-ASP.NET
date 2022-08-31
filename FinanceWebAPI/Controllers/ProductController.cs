using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FinanceWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using Microsoft.AspNetCore.Hosting;

namespace FinanceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public AppDBContext _context { get; }
        public ProductController(AppDBContext context, IWebHostEnvironment environment)
        {
            _context = context;//public property, will be responsible to do crud operations
        }
        

        /// <summary>
        /// Returns all products present in database
        /// </summary>
        [Route("")]
        public ActionResult Get()
        {
            List<Product> data = _context.Products.ToList();               
            return Ok(data);
        }
        /// <summary>
        /// Returns single product by productId
        /// </summary>
        /// <param name="id"></param>
        [Route("All/{id}")]
        public ActionResult Get(int id)
        {
            var data = _context.Products.FirstOrDefault(e => e.productId == id);
            return Ok(data);
        }
    }
}