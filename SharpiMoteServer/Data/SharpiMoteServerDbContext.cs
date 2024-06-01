using Microsoft.EntityFrameworkCore;
using SharpiMoteServer.Models;

namespace SharpiMoteServer.Data
{
    internal class SharpiMoteServerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BJRI5K4;Initial Catalog=SHARPIMOTE_DB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        DbSet<User> CLIENTS { get; set; }
    }
}
