using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataloggerDesktops.UI
{
  public partial class UpdateLine : Form
  {
    public UpdateLine()
    {
      InitializeComponent();
    }

    public UpdateLine(int index)
    {
      InitializeComponent();

      txbNameLine.Text = _managerLine.GetNameLine()[index];
    }

    RepositoryFactory _managerFactory = new RepositoryFactory();
    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryDevice _managerDevice = new RepositoryDevice();

    

    private void UpdateLine_Load(object sender, EventArgs e)
    {
      cbUpdateIdFactoryLine.DataSource = _managerFactory.GetNameFactory();
    }

    private void btnUpdateLine_Click(object sender, EventArgs e)
    {
      Line line = new Line();

      line.Id = _managerLine.GetIdLineByName(txbNameLine.Text)[0];
      line.Name = cbUpdateIdFactoryLine.SelectedItem.ToString() + " - " + txbUpdateLine.Text;
      line.DateCreate = DateTime.Now;

      line.FactoryId = _managerFactory.GetIdFactoryByName(cbUpdateIdFactoryLine.SelectedItem.ToString())[0];

      _managerLine.UpdateLine(line);
    }
  }
}
