using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  internal class ApplicationDbContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      /*
      var sqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
       @"McProtocol_EntityFrameworkCoreNet2_Database_Update\\database.db");
      if (!Directory.Exists(sqlitePath)) Directory.CreateDirectory(sqlitePath); optionsBuilder.UseSqlite("Data Source=" + sqlitePath + "\\database.db");
      */
      optionsBuilder.UseSqlite(@"Data Source=C:\Users\19146\OneDrive\Máy tính\DataloggerDesktops\DataloggerDesktop\DB\\Database.db");
    }
    public DbSet<DBiComox> DBiComoxes { get; set; }

  }
}
