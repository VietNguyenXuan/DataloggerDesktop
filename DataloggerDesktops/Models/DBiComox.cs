using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataloggerDesktops.Models
{
  public class DBiComox
  {
    [Key] public int Id { get; set; }
    public string registerAddress { get; set; }

    public string registerDescription { get; set; }
    public string registerValue { get; set; }
    public string dateTime { get; set; }
  }
}
