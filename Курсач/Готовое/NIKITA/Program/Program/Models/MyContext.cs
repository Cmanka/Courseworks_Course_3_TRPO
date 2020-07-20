using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    class MyContext : DbContext
    {
        static MyContext()
        {
            Database.SetInitializer<MyContext>(new MyContextInitializer());
        }
        public MyContext()
           : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }

    }
    class MyContextInitializer : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            context.Users.Add(new User() { Login = "Admin", Password = "123" });
            context.Masters.Add(new Master() { Name = "Galya", Number = 54464545, IsMaterial = true });
            context.Services.Add(new Service() { Name="Manikur", Price=100,Master=context.Masters.FirstOrDefault() });

            context.SaveChanges();
        }
    }
}
