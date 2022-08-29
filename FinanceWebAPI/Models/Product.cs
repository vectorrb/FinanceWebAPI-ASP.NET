using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebAPI.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public decimal productPrice { get; set; }
        public string productImageAddress { get; set; }
    }
}
/*
CREATE TABLE Products(
productId int primary key identity(1,1),
productName varchar(30),
productDescription varchar(400),
productPrice decimal,
productImageAddress varchar(100),
productImage varbinary(max) --doubt
);
*/