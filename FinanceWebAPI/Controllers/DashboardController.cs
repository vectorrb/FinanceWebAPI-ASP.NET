using FinanceWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FinanceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        public AppDBContext _context { get; }
        public DashboardController(AppDBContext context)
        {
            _context = context;//public property, will be responsible to do crud operations
        }

        [Route("/{id}")]
        public ActionResult Get(int id)
        {
            Card cardDetail = _context.Cards.FirstOrDefault(e => e.userId == id);
            return Ok(cardDetail);
        }

        [Route("productsPurchasedByUser/{id}")]
        public IActionResult productsPurchasedByUser(int id)
        {
            List<Order> OrderList = _context.Orders.Where(order => order.userId == id).ToList();

            List<int> ProductIdList = new List<int>();
            foreach (Order o in OrderList)
            {
                ProductIdList.Add(o.productId);
            }

            var recentOrderDate = _context.Orders
                .Where(o => o.userId == id)
                .Max(o => o.orderDate);

            Order recentOrder = _context.Orders
                .FirstOrDefault(o => o.orderDate == recentOrderDate && o.userId == id);

            Product recentOrderProduct = _context.Products.FirstOrDefault(p => p.productId == recentOrder.productId);

            //fetch recent transactions
            //userid => id
            //orderid => recentOrder.orderId

            //List<Transaction> recent = _context.Transactions
            //    .OrderByDescending(t => t.transactionDate)
            //    .Take(5)
            //    .Where(t => t.userId == id && t.orderId == recentOrder.orderId)
            //    .ToList();

            //fetch amount paid
            //productId = recentOrderPRoduct.productId
            //decimal amountPaid = _context.Transactions
            //    .Where(t => t.userId == id && t.productId == recentOrderProduct.productId)
            //    .Sum(t => t.transactionAmount);

            return Ok(recentOrderProduct);

        }

        [Route("getAmountForProduct/{userId}")]
        public IActionResult GetAmountPaid(int userId, int productId)
        {
            decimal amountPaid = _context.Transactions
                .Where(t => t.userId == userId && t.productId == productId)
                .Sum(t => t.transactionAmount);
            return Ok(amountPaid);
        }

        [Route("getRecentTransactions/{id}")]
        public IActionResult GetRecentTransactions(int id)
        {
            var recentOrderDate = _context.Orders
                .Where(o => o.userId == id)
                .Max(o => o.orderDate);
            
            Order recentOrder = _context.Orders
                .FirstOrDefault(o => o.orderDate == recentOrderDate && o.userId == id);
            
            List<Transaction> recentTransactions = _context.Transactions
                .OrderByDescending(t => t.transactionDate)
                .Take(5)
                .Where(t => t.userId == id && t.orderId == recentOrder.orderId)
                .ToList();

            return Ok(recentTransactions);
        }

    }
}