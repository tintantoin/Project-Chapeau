using ProjectChapeau.ChapeauModel;
using ProjectChapeau.ChapeauService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauUI
{
    internal class KeukenUI : Form, IItemBereiders
    {
        private Label label1;
        private ListView listView1;
        private ColumnHeader BesteldItemIdHdr;
        private ColumnHeader BestellingsIdHdr;
        private ColumnHeader CountHdr;
        private ColumnHeader DescriptionHdr;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ItemBereidersService service;

        public KeukenUI(ItemBereidersService service)
        {
            this.service = service;
        }

        public void FillView(Bestelling b)
        {
            throw new NotImplementedException();
        }

        public Bestelling GetBestelling(int id)
        {
            throw new NotImplementedException();
        }

        public void SetStatus()
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BesteldItemIdHdr = new System.Windows.Forms.ColumnHeader();
            this.BestellingsIdHdr = new System.Windows.Forms.ColumnHeader();
            this.CountHdr = new System.Windows.Forms.ColumnHeader();
            this.DescriptionHdr = new System.Windows.Forms.ColumnHeader();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BesteldItemIdHdr,
            this.BestellingsIdHdr,
            this.CountHdr,
            this.DescriptionHdr});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(664, 317);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BesteldItemIdHdr
            // 
            this.BesteldItemIdHdr.Tag = "";
            this.BesteldItemIdHdr.Text = "OrderId";
            this.BesteldItemIdHdr.Width = 80;
            // 
            // BestellingsIdHdr
            // 
            this.BestellingsIdHdr.Tag = "";
            this.BestellingsIdHdr.Text = "OrderNumber";
            this.BestellingsIdHdr.Width = 120;
            // 
            // CountHdr
            // 
            this.CountHdr.Tag = "";
            this.CountHdr.Text = "Count";
            // 
            // DescriptionHdr
            // 
            this.DescriptionHdr.Tag = "";
            this.DescriptionHdr.Text = "Description";
            this.DescriptionHdr.Width = 400;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(707, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 29);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(854, 156);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 29);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1001, 156);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(141, 29);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // KeukenUI
            // 
            this.ClientSize = new System.Drawing.Size(1187, 488);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "KeukenUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
