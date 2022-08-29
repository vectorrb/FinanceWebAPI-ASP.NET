using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebAPI.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            //fetches connection string
            //can have more than one Connection strings or key
        }



        //give all tables name here 
        public DbSet<User> Users { get; set; }
        public DbSet<LoginDetail> LoginDetails { get; set; }
        public DbSet<Card> Cards { get; set; }

        //this is dummy table or view for executing stored procedure
        public DbSet<Product> Products { get; set; }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<RegistrationViewModel>().HasNoKey();
        //}
    }
}
