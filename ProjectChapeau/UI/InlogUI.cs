
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
        private InlogService inlogService;
        private FormChanger formChanger;
        private Personeel logInPersoneel;
        public InlogUI()
        {
            InitializeComponent();
            pnlPopUpInlog.Hide();
            inlogService = new InlogService();
            formChanger = FormChanger.GetFormChanger();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            OpenPanel("Contact the manager to change your password");
            //inlogService.SetDBWachtwoord(1, "1111");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "")
            {
                OpenPanel("You have not entered details for username or password");
                return;
            }
            UserLogIn(txtboxUsername.Text, txtboxPassword.Text);
        }
        private void UserLogIn(string username, string password)
        {
            try
            {
                logInPersoneel = inlogService.LogUserIn(username, password);
                ResetTextBox(true);
                switch (logInPersoneel.functie)
                {
                    case FunctieType.BarPersoneel:
                        formChanger.OpenForm(new ItemBereidersUI(logInPersoneel));
                        break;
                    case FunctieType.KeukenPersoneel:
                        formChanger.OpenForm(new ItemBereidersUI(logInPersoneel));
                        break;
                    case FunctieType.Manager:
                        break;
                    case FunctieType.Bediening:
                        formChanger.OpenForm(new TafelOverzicht(logInPersoneel.voornaam));
                        break;
                    default:
                        OpenPanel("Invalid username or password");
                        break;
                }
            }
            catch (Exception Ex)
            {
                OpenPanel($"You entered the wrong {Ex.Message}");
                if (Ex.Message == "username")
                {
                    ResetTextBox(true);
                }
                else
                {
                    ResetTextBox(false);
                }
            }
        }
        private void ResetTextBox(bool username)
        {
            if (username)
            {
                txtboxUsername.Text = "";
            }
            txtboxPassword.Text = "";
        }
        private void btnInvalidNameOrPass_Click(object sender, EventArgs e)
        {
            pnlPopUpInlog.Hide();
        }
        private void OpenPanel(string text)
        {
            lblPopUpInlog.Text = text;
            lblPopUpInlog.Left = labelBuffer/text.Length; 
            pnlPopUpInlog.Show();
        }
    }
}
