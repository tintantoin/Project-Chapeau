using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace ProjectChapeau.ChapeauUI
{
    public partial class PaymentUI : Form, IObservable
    {
        private decimal changeAmount;
        private string feedback;
        private string customerPaid;
        private decimal tip;
        private string order;
        private List<IObserver> observables;

        public PaymentUI()
        {
            InitializeComponent();
            observables = new List<IObserver>();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vat_Click(object sender, EventArgs e)
        {

        }

        private void orderPrice_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                cardPanelPayment.Visible = true;
                cardPanelPayment.Location = new Point(-2, -7);
            }
            else if (radioButton2.Checked)
            {
                cardPanelPayment.Visible = true;
                cardPanelPayment.Location = new Point(-2, -7);
            }
            else
            {
                cardPanelPayment.Visible = false;
            }

            if (cashButton.Checked)
            {
                cashPaymentPanel.Visible = true;
                cashPaymentPanel.Location = new Point(-2, -7);
            }
            else
            {
                cashPaymentPanel.Visible = false;
            }
            if (groupPayment.Checked)
            {
                panel2.Visible = true;
                panel2.Location = new Point(-2, -7);

                decimal totalPrice = decimal.Parse(label53.Text.Replace("€", ""));
                decimal individualPayment = totalPrice / 4;
                label60.Text = $"€{individualPayment:F2}";
            }
            else
            {
                panel2.Visible = false;
            }

            if (cashCard.Checked)
            {
                cashCardPaymentPanel.Visible = true;
                cashCardPaymentPanel.Location = new Point(-2, -7);
            }
            else
            {
                cashCardPaymentPanel.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal enteredAmount;
            if (decimal.TryParse(amountPaid.Text, out enteredAmount))
            {
                decimal orderPrice;
                if (decimal.TryParse(price.Text.Replace("€", ""), out orderPrice))
                {
                    decimal returnAmount = enteredAmount - orderPrice;

                    if (returnAmount >= 0)
                    {
                        customerChange.Text = $"Customers change is €{returnAmount:F2}";
                        changeAmount = returnAmount;
                    }
                }
            }
        }
        private void PaymentUI_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "3 gerechten: €80\n4 drinken €15\n 1 wijn €10\n2 dessert €8";
        }

        private void calculateReturnCashCard_Click(object sender, EventArgs e)
        {
            decimal billedAmount;
            if (decimal.TryParse(totalAmount.Text.Replace("€", ""), out billedAmount))
            {
                decimal cashAmount;
                decimal cardAmount;

                if (decimal.TryParse(amountCash.Text, out cashAmount) && decimal.TryParse(amountCard.Text, out cardAmount))
                {
                    decimal returnAmount = cashAmount + cardAmount - billedAmount;

                    if (returnAmount >= 0)
                    {
                        label23.Text = $"€{returnAmount:F2} change";
                        changeAmount = returnAmount;
                    }
                }
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            label24.Text = $"€{changeAmount} tip has been added.";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label28.Text = $"€{changeAmount} tip has been added.";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label29.Text = $"€{changeAmount} tip has been added.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal enteredAmount;
            if (decimal.TryParse(textBox4.Text, out enteredAmount))
            {
                decimal orderPrice;
                if (decimal.TryParse(label19.Text.Replace("€", ""), out orderPrice))
                {
                    decimal returnAmount = enteredAmount - orderPrice;

                    if (returnAmount >= 0)
                    {
                        label13.Text = $"Customers change is €{returnAmount:F2}";
                        changeAmount = returnAmount;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox5.Text, out decimal enteredNumber))
            {
                label33.Text = $"€{enteredNumber}  tip has been added.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox6.Text, out decimal enteredNumber))
            {
                label34.Text = $"€{enteredNumber} tip has been added.";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox7.Text, out decimal enteredNumber))
            {
                label35.Text = $"€{enteredNumber} tip has been added.";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            order = price.Text;
            label41.Text = order;

            customerPaid = "€" + decimal.Parse(amountPaid.Text).ToString("F2");
            label42.Text = customerPaid;

            if (label29.Text.Contains("tip"))
            {
                tip = changeAmount;
                label43.Text = $"€{tip:F2}";
            }
            else
            {
                if (decimal.TryParse(textBox7.Text, out tip))
                {
                    label43.Text = $"€{tip:F2}";
                }
            }

            feedback = textBox1.Text;
            label44.Text = feedback;

            cashPaymentPanel.Hide();
            panel1.Show();
            panel1.Location = new Point(-2, -7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            order = totalAmount.Text;
            label41.Text = order;

            decimal cashAmount = decimal.Parse(amountCash.Text);
            decimal cardAmount = decimal.Parse(amountCard.Text);
            decimal totalPayment = cashAmount + cardAmount;
            customerPaid = label42.Text = totalPayment.ToString("C");

            if (label24.Text.Contains("tip"))
            {
                tip = changeAmount;
                label43.Text = $"€{tip:F2}";
            }
            else
            {
                if (decimal.TryParse(textBox5.Text, out tip))
                {
                    label43.Text = $"€{tip:F2}";
                }
            }

            feedback = textBox2.Text;
            label44.Text = feedback;

            cashCardPaymentPanel.Hide();
            panel1.Show();
            panel1.Location = new Point(-2, -7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            order = label19.Text;
            label41.Text = order;

            customerPaid = "€" + decimal.Parse(textBox4.Text).ToString("F2");
            label42.Text = customerPaid;

            if (label28.Text.Contains("tip"))
            {
                tip = changeAmount;
                label43.Text = $"€{tip:F2}";
            }
            else
            {
                if (decimal.TryParse(textBox6.Text, out tip))
                {
                    label43.Text = $"€{tip:F2}";
                }
            }

            feedback = textBox3.Text;
            label44.Text = feedback;

            cardPanelPayment.Hide();
            panel1.Show();
            panel1.Location = new Point(-2, -7);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            decimal billedAmount;
            if (decimal.TryParse(label53.Text.Replace("€", ""), out billedAmount))
            {
                decimal cashAmount1, cashAmount2, cashAmount3, cashAmount4;
                if (decimal.TryParse(customer1.Text, out cashAmount1) &&
                    decimal.TryParse(customer2.Text, out cashAmount2) &&
                    decimal.TryParse(customer3.Text, out cashAmount3) &&
                    decimal.TryParse(customer4.Text, out cashAmount4))
                {
                    decimal totalCashAmount = cashAmount1 + cashAmount2 + cashAmount3 + cashAmount4;
                    decimal individualShare = billedAmount / 4;
                    decimal totalChange = totalCashAmount - (individualShare * 4);
                    label49.Text = $"Total Change: €{totalChange:F2}";
                    changeAmount = totalChange;
                }
            }
        }

        private void panel2_Load(object sender, EventArgs e)
        {

        }
            private void label60_Click(object sender, EventArgs e)
            {

            }

        private void button16_Click(object sender, EventArgs e)
        {
            label48.Text = $"€{changeAmount} tip has been added.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox8.Text, out decimal enteredNumber))
            {
                label45.Text = $"€{enteredNumber} tip has been added.";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            order = label53.Text;
            label41.Text = order;

            decimal cashAmount1 = decimal.Parse(customer1.Text);
            decimal cashAmount2 = decimal.Parse(customer2.Text);
            decimal cashAmount3 = decimal.Parse(customer3.Text);
            decimal cashAmount4 = decimal.Parse(customer4.Text);

            decimal totalPayment = cashAmount1 + cashAmount2 + cashAmount3 + cashAmount4;
            customerPaid = label42.Text = totalPayment.ToString("C");

            if (label48.Text.Contains("tip"))
            {
                tip = changeAmount;
                label43.Text = $"€{tip:F2}";
            }
            else
            {
                if (decimal.TryParse(textBox8.Text, out tip))
                {
                    label43.Text = $"€{tip:F2}";
                }
            }

            feedback = textBox10.Text;
            label44.Text = feedback;

            panel2.Hide();
            panel1.Show();
            panel1.Location = new Point(-2, -7);
        }

        private void button13_Click(object sender, EventArgs e)
        {

            //decimal totalAmount = decimal.Parse(label41.Text);
            //decimal tipAmount = decimal.Parse(label43.Text);
            //string feedback = textBox1.Text;

            paymenttable paymenttable = new paymenttable();
            paymenttable.changeColor();
            paymenttable.Show();
        }

        void IObservable.AddObserver(IObserver observer)
        {
            observables.Add(observer);
        }

        void IObservable.RemoveObserver(IObserver observer)
        {
            observables.Remove(observer);
        }
    }
}
