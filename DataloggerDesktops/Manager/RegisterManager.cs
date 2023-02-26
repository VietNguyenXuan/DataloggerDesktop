using DataloggerDesktops.Gateway;
using DataloggerDesktops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Manager
{
  public class RegisterManager
  {
    RegisterGateway _registerGateway = new RegisterGateway();

    public bool AddData(DBiComox dBiComox)
    {
      return _registerGateway.AddData(dBiComox);
    }

    public List<DBiComox> GetAll()
    {
      return _registerGateway.GetAll();
    }

    public List<DBiComox> GetData(string RegAdd)
    {
      return _registerGateway.GetData(RegAdd);
    }
  }
}
