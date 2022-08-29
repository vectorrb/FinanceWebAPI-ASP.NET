using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebAPI.Models
{
    public class Transaction
    {
        [Key]
        public int transactionId { get; set; }
        public int userId { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public DateTime transactionDate { get; set; }
        public decimal transactionAmount { get; set; }
    }
}
/*CREATE TABLE Transactions(
transactionId int primary key identity(1,1),
userId int,
orderId int,
productId int,
transactionDate DateTime,
transactionAmount decimal,
);
*/