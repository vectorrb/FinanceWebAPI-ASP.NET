using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebAPI.Models
{
    public class LoginDetail
    {
        [Key]
        public int loginId { get; set; }
        public int userId { get; set; }
        public string userEmail { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
    }
}
/*
 CREATE TABLE LoginDetails(
loginId int primary key identity(1,1),
userId int NOT NULL,
userEmail varchar(30),
password varchar(20),
confirmPassword varchar(20)
);
 */
