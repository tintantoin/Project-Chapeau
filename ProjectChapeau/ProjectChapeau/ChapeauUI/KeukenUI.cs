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
        private Label TitelLbl;
        private ListView BestellingenList;
        private ColumnHeader BesteldItemIdHdr;
        private ColumnHeader BestellingsIdHdr;
        private ColumnHeader CountHdr;
        private ColumnHeader DescriptionHdr;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
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
            this.TitelLbl = new System.Windows.Forms.Label();
            this.BestellingenList = new System.Windows.Forms.ListView();
            this.BesteldItemIdHdr = new System.Windows.Forms.ColumnHeader();
            this.BestellingsIdHdr = new System.Windows.Forms.ColumnHeader();
            this.CountHdr = new System.Windows.Forms.ColumnHeader();
            this.DescriptionHdr = new System.Windows.Forms.ColumnHeader();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitelLbl
            // 
            this.TitelLbl.AutoSize = true;
            this.TitelLbl.Location = new System.Drawing.Point(594, 32);
            this.TitelLbl.Name = "TitelLbl";
            this.TitelLbl.Size = new System.Drawing.Size(128, 25);
            this.TitelLbl.TabIndex = 0;
            this.TitelLbl.Text = "Keuken Orders";
            // 
            // BestellingenList
            // 
            this.BestellingenList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BesteldItemIdHdr,
            this.BestellingsIdHdr,
            this.CountHdr,
            this.DescriptionHdr});
            this.BestellingenList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BestellingenList.GridLines = true;
            this.BestellingenList.Location = new System.Drawing.Point(12, 80);
            this.BestellingenList.Name = "BestellingenList";
            this.BestellingenList.Size = new System.Drawing.Size(664, 317);
            this.BestellingenList.TabIndex = 1;
            this.BestellingenList.UseCompatibleStateImageBehavior = false;
            this.BestellingenList.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(979, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(966, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // KeukenUI
            // 
            this.ClientSize = new System.Drawing.Size(1187, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BestellingenList);
            this.Controls.Add(this.TitelLbl);
            this.Name = "KeukenUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
