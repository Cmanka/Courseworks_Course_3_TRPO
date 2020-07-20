using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Model
{
    class MyAppContext : DbContext
    {
        static MyAppContext()
        {
            Database.SetInitializer<MyAppContext>(new MyContextInitializer());
        }
        public MyAppContext()
           : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Seller> Selleres { get; set; }
    }
    class MyContextInitializer : CreateDatabaseIfNotExists<MyAppContext>
    {
        protected override void Seed(MyAppContext context)
        {
            context.Users.Add(new User() { Login = "User", Password = "12345" });

            context.SaveChanges();
        }
    }
}
