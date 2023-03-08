using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.Repository
{
  public class RepositoryFactory
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();
    public async Task Add(Factory factory)
    {
      await _dbContext.Database.BeginTransactionAsync();
      try
      {
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.Factories.AddAsync(factory);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();

        MessageBox.Show("Đã thêm nhà máy thành công");
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }

    //public async Task<List<Factory>> GetAll()
    //{
    //  await _dbContext.Database.EnsureCreatedAsync();
    //  return await _dbContext.Factories.ToListAsync();
    //}

    public List<Factory>? GetAll()
    {
      _dbContext.Database.EnsureCreated();
      var line = _dbContext.Factories.ToList();
      if (line != null)
      {
        return line;
      }
      return null;
    }

    public async Task Delete(int id)
    {
      await _dbContext.Database.BeginTransactionAsync();

      try
      {
        var factory = _dbContext.Factories.SingleOrDefault(m => m.Id == id);
        _dbContext.Factories.Remove(factory);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Database.CommitTransactionAsync();
      }
      catch (Exception)
      {
        await _dbContext.Database.RollbackTransactionAsync();
      }
    }

    public List<int>? GetAllIdFactory()
    {
      _dbContext.Database.EnsureCreated();
      var factory = _dbContext.Factories.Select(s => s.Id).ToList();

      if (factory != null)
      {
        return factory;
      }
      return null;
    }


    public List<int>? GetIdFactory()
    {
      _dbContext.Database.EnsureCreated();
      var factory = _dbContext.Factories.Select(s => s.Id).ToList();

      if (factory != null)
      {
        return factory;
      }
      return null;
    }

    public List<string>? GetNameFactory()
    {
      _dbContext.Database.EnsureCreated();
      var factory = _dbContext.Factories.Select(s => s.Name).ToList();

      if (factory != null)
      {
        return factory;
      }
      return null;
    }

    public List<int>? GetIdFactory(string name)
    {
      _dbContext.Database.EnsureCreated();
      var line = _dbContext.Factories.Where(s => s.Name == name).Take(1).ToList();

      if (line != null)
      {
        return line.Select(s => s.Id).ToList();
      }

      return null;
    }

    public void UpdateFactory(Factory factory)
    {
      var data = _dbContext.Factories.FirstOrDefault(d => d.Id == factory.Id);

      if (data != null)
      {
        data.Name = factory.Name;
        data.DateCreate = factory.DateCreate;

        _dbContext.SaveChanges();
      }
    }

  }
}
