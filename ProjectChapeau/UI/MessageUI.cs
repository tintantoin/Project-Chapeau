using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class MessageUI : Form
    {

        private MenuItem item;
        public MessageUI(MenuItem item)
        {
            InitializeComponent();
            this.item = item;
        }

        public void setDescription()
        {
            item.Opmerking = item.Name; 
            item.Opmerking += OpmerkingBox.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setDescription();
        }
    }
}
