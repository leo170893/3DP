using System;
using System.Data.Entity;
using _3DP.Areas.Admin.Models.Entities;

namespace _3DP.Areas.Admin.Models.BusinessModels
{
    public class DBContextCommon : DbContext
    {
        public DBContextCommon() : base("name=3DPConnectionString")
        {

        }
        //public DbSet<User> DSUser { set; get; }
        public DbSet<Category> DSCategory { set; get; }
        //public DbSet<Bill> DSBill { set; get; }
        //public DbSet<Order> DSOrder { set; get; }
        public DbSet<Product> DSProduct { set; get; }
        //public DbSet<News> DSNews { set; get; }
        //public DbSet<Promote> DSPromote { set; get; }
    }
}