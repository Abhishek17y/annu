using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Annu.Models
{
    public class ApplicationDbContext:DbContext
    {
        internal object user;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<VerifyAccount> VerifyAccounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
