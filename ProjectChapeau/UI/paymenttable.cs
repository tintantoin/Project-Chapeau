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
    public partial class paymenttable : Form
    {
        public paymenttable()
        {
            InitializeComponent();
        }

        private void Table1clicked_Click(object sender, EventArgs e)
        {
        }

        private void tableClicked_Click(object sender, EventArgs e)
        {
            var paymentUI = new PaymentUI();
            paymentUI.Show();
        }
        public void changeColor()
        {
            tableClicked.BackColor = SystemColors.GradientActiveCaption;
        }
    }
}
