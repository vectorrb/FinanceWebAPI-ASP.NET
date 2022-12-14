using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebAPI.Models
{
    public class Order
    {
        [Key]
        public int orderId { get; set; }
        public int productId { get; set; }
        public int userId { get; set; }
        public DateTime orderDate { get; set; }
        public decimal orderAmount { get; set; }
        public int emiType { get; set; }
        public bool isActivated { get; set; }
    }
}