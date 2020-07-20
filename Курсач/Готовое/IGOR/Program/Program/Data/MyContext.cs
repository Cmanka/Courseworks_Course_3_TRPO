using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Data
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
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
    class MyContextInitializer : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            context.Users.Add(new User() { Login = "User", Password = "12345" });

            context.SaveChanges();
        }
    }
}
