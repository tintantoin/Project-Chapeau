using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectChapeau.ChapeauUI
{
    public partial class InlogUI : Form
    {
        public InlogUI()
        {
            InitializeComponent();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!", "Message Box Example", MessageBoxButtons.OK);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
