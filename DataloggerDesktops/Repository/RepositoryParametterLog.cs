using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataloggerDesktops.Repository
{
  public class RepositoryParametterLog
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(ParametterLog parametterLog)
    {
      await _dbContext.Database.BeginTransactionAsync();
      try
      {
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.ParametterLogs.AddAsync(parametterLog);
        await _dbContext.SaveChangesAsync();
        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }


    public List<ParametterLog>? GetAll()
    {
      _dbContext.Database.EnsureCreated();
      var parametriclogs = _dbContext.ParametterLogs.ToList();

      if (parametriclogs != null)
      {
        return parametriclogs;
      }

      return null;
    }

    public float? GetValueByIdParametter(int id)
    {
      _dbContext.Database.EnsureCreated();
      var value = _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == id).OrderByDescending(s=>s.Id).Select(s => s.Value).FirstOrDefault();
      if (value != null)
      {
        return value;
      }
      return null;
    }

    public List<ParametterLog> GetValuesByIdParametter(int idPara)
    {
      _dbContext.Database.EnsureCreated();
      var values = _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).OrderByDescending(s => s.Id).Take(10).ToList();
      if (values != null)
      {
        return values;
      }
      return null;
    }




    //public List<ParametterLog> GetValuesByIdParametter(int idPara)
    //{
    //  _dbContext.Database.EnsureCreated();
    //  var values = _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).OrderByDescending(s => s.Id).Select(s => s.Value).Take(10).ToList();
    //  if (values != null)
    //  {
    //    return values;
    //  }
    //  return null;
    //}

  }
}
