using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

    public List<ParametterLog>? GetValuesByIdParametter(int idPara)
    {
      _dbContext.Database.EnsureCreated();
      var values = _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).OrderByDescending(s => s.Id).ToList();
      if (values != null)
      {
        return values;
      }
      return null;
    }


    public ParametterLog? iChart(int idPara, int hour)
    {
      _dbContext.Database.EnsureCreated();
      var values = _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).Where(x => x.DateCreate.Hour == hour).OrderByDescending(s => s.Id).FirstOrDefault();
      if (values != null)
      {
        return values;
      }
      return null;
    }


    public iChart? Viet(int idPara, int hour)
    {
      _dbContext.Database.EnsureCreated();
      var values = _dbContext.ParametterLogs.Where(s => s.ParametterSensorId == idPara).Where(x => x.DateCreate.Hour == hour).OrderByDescending(s => s.Id).FirstOrDefault();
      if (values != null)
      {
        return new iChart
        {
          DateCreate = values.DateCreate,
          Value = (float)values.Value
        };
      }
      return null;
    }

  }
}
