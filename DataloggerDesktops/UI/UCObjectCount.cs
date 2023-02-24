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
    public partial class UCObjectCount : UserControl
    {
        public UCObjectCount()
        {
            InitializeComponent();
        }

        public UCObjectCount(string user)
        {
            InitializeComponent();
            this.lblName.Text = user;
        }
    }
}
