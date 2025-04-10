using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.DomainModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Model
{
    public class AppDbConnection : DbContext
    {
        public AppDbConnection(DbContextOptions options) : base(options)
        {
        }
        public AppDbConnection() { }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source = DESKTOP - 1F3UU3Q; Initial Catalog=FinalProject;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
    }
    
       
}
