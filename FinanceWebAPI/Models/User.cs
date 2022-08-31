using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebAPI.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string account_number { get; set; }
        public string ifsc_code { get; set; }
        public bool is_verified { get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}

