
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class InlogUI : Form
    {
        InlogService InlogService;
        FormChanger formChanger;
        public InlogUI()
        {
            InitializeComponent();
            panelNoUserNameAndPassword.Hide();
            InlogService = new InlogService();
            formChanger = FormChanger.GetFormChanger();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //InlogService.SetDBWachtwoord(4, "4444");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "")
            {
                lblNotEnteredAll.Text = "You have not entered details for username or password";
                panelNoUserNameAndPassword.Show();
                return;
            }

            string userName = txtboxUsername.Text;
            string password = txtboxPassword.Text;
            FunctieType type = InlogService.LogUserIn(userName, password);
            switch (type)
            {
                case FunctieType.BarPersoneel:
                    break;
                case FunctieType.KeukenPersoneel:
                    formChanger.OpenForm(new KeukenUI());
                    break;
                case FunctieType.Manager:
                    break;
                case FunctieType.Bediening:
                    formChanger.OpenForm(new TafelOverzicht());
                    break;
                default:
                    NoLogin();
                    break;
            }
        }
        private void btnInvalidNameOrPass_Click(object sender, EventArgs e)
        {
            panelNoUserNameAndPassword.Hide();
        }
        private void NoLogin()
        {
            panelNoUserNameAndPassword.Show();
            lblNotEnteredAll.Text = "                   Invalid username or password";
        }
        private void OpenPanel()
        {
            panelNoUserNameAndPassword.Show();
        }
    }
}
