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
    public partial class TafelStatusUI : Form
    {
        public TafelStatusUI()
        {
            InitializeComponent();
        }
        public void TableNumber(int tableNumber)
        {
            lblTheTable.Text = "Table " + tableNumber.ToString();
        }

        private void btnBackTafelStatus_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
