using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebAPI.Models
{
    public class Card
    {
        [Key]
        public int cardId { get; set; }
        public int userId { get; set; }
        public string cardType { get; set; }
        public decimal accountBalance { get; set; }
        public DateTime expiryDate { get; set; }
        public string bankname { get; set; }
    }
}
