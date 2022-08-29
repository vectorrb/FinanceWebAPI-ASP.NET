using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebAPI.Models
{
    public class Admin
    {
        [Key]
        public int  adminId{ get; set; }
        public string adminName { get; set; }
        public string adminPassword { get; set; }
    }
}
/*CREATE TABLE Admins(
adminId int primary key identity(100,1),
adminName varchar(20),
adminPassword varchar(20)
);
*/