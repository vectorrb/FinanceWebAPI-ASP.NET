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