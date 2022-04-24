using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Login
{
    public partial class DlgLogin : Form
    {
        public DlgLogin()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Profile1;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
