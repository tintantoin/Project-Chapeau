using ProjectChapeau.ChapeauModel;
using ProjectChapeau.ChapeauService;
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
        InlogService InlogService;
        public InlogUI()
        {
            InitializeComponent();
            InlogService = new InlogService();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //InlogService.SetDBWachtwoord(4, "4444");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "")
            {
                MessageBox.Show($"Fill something");
                return;
            }
            string userName = txtboxUsername.Text;
            string password = txtboxPassword.Text;
            FunctieType type = InlogService.LogUserIn(userName, password);
            if (type != FunctieType.GeenFunctie)
            {
                MessageBox.Show($"Log {type}");
            }
            else
            {
                MessageBox.Show($"niks");
            }

            //log user in (userName, password)
        }
    }
}
