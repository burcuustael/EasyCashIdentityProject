using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KOJI8U6;initial catalog=EasyCashDb;integrated security=true");

        }

        public DbSet<CustomerAccount> CustomerAccounts {get; set;}
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
    }
}
