using DataloggerDesktops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.Repository
{
  public class RepositoryParametterSensors
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task Add(ParametterSensor parametterSensor)
    {
      await _dbContext.Database.BeginTransactionAsync();
      try
      {
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.ParametterSensors.AddAsync(parametterSensor);
        await _dbContext.SaveChangesAsync();
        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }


    public List<ParametterSensor>? GetAll()
    {
      _dbContext.Database.EnsureCreated();
      var parametricSensors = _dbContext.ParametterSensors.ToList();
      if (parametricSensors != null)
      {
        return parametricSensors;
      }
      return null;
    }


    public int? GetIdByName(string name)
    {
      _dbContext.Database.EnsureCreated();
      var idParametter = _dbContext.ParametterSensors.Where(s => s.Name == name).Select(s => s.Id).FirstOrDefault();

      if (idParametter != null)
      {
        return idParametter;
      }

      return null;
    }





  }
}
