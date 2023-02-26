using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Gateway
{
  public class RegisterGateway
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();
    public bool AddData(DBiComox dBicomox)
    {
      _dbContext.Database.EnsureCreated();
      _dbContext.DBiComoxes.Add(dBicomox);
      return _dbContext.SaveChanges() > 0;
    }

    internal List<DBiComox> GetAll()
    {
      _dbContext.Database.EnsureCreated();
      return _dbContext.DBiComoxes.ToList();
    }

    internal List<DBiComox> GetData(string ReAdd)
    {
      _dbContext.Database.EnsureCreated();
      return _dbContext.DBiComoxes
              .Where(s => s.registerAddress == ReAdd)
              .OrderByDescending(s => s.Id)
              .ToList();
    }
  }
}
