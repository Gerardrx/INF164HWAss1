using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmLoadingScreen : Form
    {
        public frmLoadingScreen()
        {
            InitializeComponent();

            Arcade a = new Arcade();
            a.Visible = true;
        }

        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
