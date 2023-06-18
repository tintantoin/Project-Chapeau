
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UI
{
    public partial class InlogUI : Form
    {
        private const int labelBuffer = 3000;
        private InlogService InlogService;
        private FormChanger formChanger;
        public InlogUI()
        {
            InitializeComponent();
            pnlPopUpInlog.Hide();
            InlogService = new InlogService();
            formChanger = FormChanger.GetFormChanger();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            OpenPanel("Contact the manager to change your password");
            //InlogService.SetDBWachtwoord(4, "4444");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "")
            {
                OpenPanel("You have not entered details for username or password");
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
                    formChanger.OpenForm(new TafelOverzicht(InlogService.ReturnName(userName, password)));
                    break;
                default:
                    NoLogin();
                    break;
            }
            if (type != FunctieType.GeenFunctie)
            {
                txtboxUsername.Text = "";
            }
            txtboxPassword.Text = "";
        }
        private void btnInvalidNameOrPass_Click(object sender, EventArgs e)
        {
            pnlPopUpInlog.Hide();
        }
        private void NoLogin()
        {
            OpenPanel("Invalid username or password");
        }
        private void OpenPanel(string text)
        {
            lblPopUpInlog.Text = text;
            lblPopUpInlog.Left = labelBuffer/text.Length; 
            pnlPopUpInlog.Show();
        }
    }
}
