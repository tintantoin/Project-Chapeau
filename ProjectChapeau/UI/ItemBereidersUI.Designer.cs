﻿namespace UI
{
    partial class ItemBereidersUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderStatusLbl = new System.Windows.Forms.Label();
            this.SelectedOrderLbl = new System.Windows.Forms.Label();
            this.OrderStatusIndicLbl = new System.Windows.Forms.Label();
            this.Selectedorderindiclbl = new System.Windows.Forms.Label();
            this.SelectOrderBtn = new System.Windows.Forms.Button();
            this.InPrepListview = new System.Windows.Forms.ListView();
            this.BesteldItemIdHdr = new System.Windows.Forms.ColumnHeader();
            this.BestellingsIdHdr = new System.Windows.Forms.ColumnHeader();
            this.CountHdr = new System.Windows.Forms.ColumnHeader();
            this.DescriptionHdr = new System.Windows.Forms.ColumnHeader();
            this.TitelLbl = new System.Windows.Forms.Label();
            this.InPreparationBtn = new System.Windows.Forms.Button();
            this.PreparedBtn = new System.Windows.Forms.Button();
            this.ServedBtn = new System.Windows.Forms.Button();
            this.NotStartedListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.PreparedListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.SelectOrdertxt = new System.Windows.Forms.TextBox();
            this.InPrepLbl = new System.Windows.Forms.Label();
            this.NotStartedLbl = new System.Windows.Forms.Label();
            this.PreparedLbl = new System.Windows.Forms.Label();
            this.SelectIdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderStatusLbl
            // 
            this.OrderStatusLbl.AutoSize = true;
            this.OrderStatusLbl.Location = new System.Drawing.Point(992, 354);
            this.OrderStatusLbl.Name = "OrderStatusLbl";
            this.OrderStatusLbl.Size = new System.Drawing.Size(17, 25);
            this.OrderStatusLbl.TabIndex = 29;
            this.OrderStatusLbl.Text = " ";
            // 
            // SelectedOrderLbl
            // 
            this.SelectedOrderLbl.AutoSize = true;
            this.SelectedOrderLbl.Location = new System.Drawing.Point(753, 354);
            this.SelectedOrderLbl.Name = "SelectedOrderLbl";
            this.SelectedOrderLbl.Size = new System.Drawing.Size(17, 25);
            this.SelectedOrderLbl.TabIndex = 28;
            this.SelectedOrderLbl.Text = " ";
            // 
            // OrderStatusIndicLbl
            // 
            this.OrderStatusIndicLbl.AutoSize = true;
            this.OrderStatusIndicLbl.Location = new System.Drawing.Point(966, 300);
            this.OrderStatusIndicLbl.Name = "OrderStatusIndicLbl";
            this.OrderStatusIndicLbl.Size = new System.Drawing.Size(110, 25);
            this.OrderStatusIndicLbl.TabIndex = 27;
            this.OrderStatusIndicLbl.Text = "Order status";
            // 
            // Selectedorderindiclbl
            // 
            this.Selectedorderindiclbl.AutoSize = true;
            this.Selectedorderindiclbl.Location = new System.Drawing.Point(716, 300);
            this.Selectedorderindiclbl.Name = "Selectedorderindiclbl";
            this.Selectedorderindiclbl.Size = new System.Drawing.Size(154, 25);
            this.Selectedorderindiclbl.TabIndex = 26;
            this.Selectedorderindiclbl.Text = " Selected order ID\n";
            // 
            // SelectOrderBtn
            // 
            this.SelectOrderBtn.Location = new System.Drawing.Point(214, 862);
            this.SelectOrderBtn.Name = "SelectOrderBtn";
            this.SelectOrderBtn.Size = new System.Drawing.Size(141, 48);
            this.SelectOrderBtn.TabIndex = 25;
            this.SelectOrderBtn.Text = "Select OrderId";
            this.SelectOrderBtn.UseVisualStyleBackColor = true;
            this.SelectOrderBtn.Click += new System.EventHandler(this.SelectOrderBtn_Click);
            // 
            // InPrepListview
            // 
            this.InPrepListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BesteldItemIdHdr,
            this.BestellingsIdHdr,
            this.CountHdr,
            this.DescriptionHdr});
            this.InPrepListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InPrepListview.GridLines = true;
            this.InPrepListview.Location = new System.Drawing.Point(12, 98);
            this.InPrepListview.Name = "InPrepListview";
            this.InPrepListview.Size = new System.Drawing.Size(664, 203);
            this.InPrepListview.TabIndex = 21;
            this.InPrepListview.UseCompatibleStateImageBehavior = false;
            this.InPrepListview.View = System.Windows.Forms.View.Details;
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
            // TitelLbl
            // 
            this.TitelLbl.AutoSize = true;
            this.TitelLbl.Location = new System.Drawing.Point(569, 16);
            this.TitelLbl.Name = "TitelLbl";
            this.TitelLbl.Size = new System.Drawing.Size(0, 25);
            this.TitelLbl.TabIndex = 20;
            // 
            // InPreparationBtn
            // 
            this.InPreparationBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InPreparationBtn.Location = new System.Drawing.Point(725, 98);
            this.InPreparationBtn.Name = "InPreparationBtn";
            this.InPreparationBtn.Size = new System.Drawing.Size(135, 53);
            this.InPreparationBtn.TabIndex = 30;
            this.InPreparationBtn.Text = "In preparation";
            this.InPreparationBtn.UseVisualStyleBackColor = false;
            // 
            // PreparedBtn
            // 
            this.PreparedBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.PreparedBtn.Location = new System.Drawing.Point(880, 98);
            this.PreparedBtn.Name = "PreparedBtn";
            this.PreparedBtn.Size = new System.Drawing.Size(129, 53);
            this.PreparedBtn.TabIndex = 31;
            this.PreparedBtn.Text = "Prepared";
            this.PreparedBtn.UseVisualStyleBackColor = false;
            // 
            // ServedBtn
            // 
            this.ServedBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ServedBtn.Location = new System.Drawing.Point(1026, 98);
            this.ServedBtn.Name = "ServedBtn";
            this.ServedBtn.Size = new System.Drawing.Size(123, 53);
            this.ServedBtn.TabIndex = 32;
            this.ServedBtn.Text = "Served";
            this.ServedBtn.UseVisualStyleBackColor = false;
            // 
            // NotStartedListView
            // 
            this.NotStartedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.NotStartedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotStartedListView.GridLines = true;
            this.NotStartedListView.Location = new System.Drawing.Point(12, 354);
            this.NotStartedListView.Name = "NotStartedListView";
            this.NotStartedListView.Size = new System.Drawing.Size(664, 203);
            this.NotStartedListView.TabIndex = 33;
            this.NotStartedListView.UseCompatibleStateImageBehavior = false;
            this.NotStartedListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "OrderId";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "OrderNumber";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "";
            this.columnHeader3.Text = "Count";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "";
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 400;
            // 
            // PreparedListView
            // 
            this.PreparedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.PreparedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreparedListView.GridLines = true;
            this.PreparedListView.Location = new System.Drawing.Point(12, 622);
            this.PreparedListView.Name = "PreparedListView";
            this.PreparedListView.Size = new System.Drawing.Size(664, 203);
            this.PreparedListView.TabIndex = 34;
            this.PreparedListView.UseCompatibleStateImageBehavior = false;
            this.PreparedListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "OrderId";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "";
            this.columnHeader6.Text = "OrderNumber";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Tag = "";
            this.columnHeader7.Text = "Count";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Tag = "";
            this.columnHeader8.Text = "Description";
            this.columnHeader8.Width = 400;
            // 
            // SelectOrdertxt
            // 
            this.SelectOrdertxt.Location = new System.Drawing.Point(12, 871);
            this.SelectOrdertxt.Name = "SelectOrdertxt";
            this.SelectOrdertxt.Size = new System.Drawing.Size(150, 31);
            this.SelectOrdertxt.TabIndex = 35;
            // 
            // InPrepLbl
            // 
            this.InPrepLbl.AutoSize = true;
            this.InPrepLbl.Location = new System.Drawing.Point(28, 52);
            this.InPrepLbl.Name = "InPrepLbl";
            this.InPrepLbl.Size = new System.Drawing.Size(123, 25);
            this.InPrepLbl.TabIndex = 36;
            this.InPrepLbl.Text = "In Preparation";
            // 
            // NotStartedLbl
            // 
            this.NotStartedLbl.AutoSize = true;
            this.NotStartedLbl.Location = new System.Drawing.Point(28, 315);
            this.NotStartedLbl.Name = "NotStartedLbl";
            this.NotStartedLbl.Size = new System.Drawing.Size(98, 25);
            this.NotStartedLbl.TabIndex = 37;
            this.NotStartedLbl.Text = "NotStarted";
            // 
            // PreparedLbl
            // 
            this.PreparedLbl.AutoSize = true;
            this.PreparedLbl.Location = new System.Drawing.Point(28, 580);
            this.PreparedLbl.Name = "PreparedLbl";
            this.PreparedLbl.Size = new System.Drawing.Size(83, 25);
            this.PreparedLbl.TabIndex = 38;
            this.PreparedLbl.Text = "Prepared";
            // 
            // SelectIdLbl
            // 
            this.SelectIdLbl.AutoSize = true;
            this.SelectIdLbl.Location = new System.Drawing.Point(12, 843);
            this.SelectIdLbl.Name = "SelectIdLbl";
            this.SelectIdLbl.Size = new System.Drawing.Size(149, 25);
            this.SelectIdLbl.TabIndex = 39;
            this.SelectIdLbl.Text = "Select an OrderId";
            // 
            // ItemBereidersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 922);
            this.Controls.Add(this.SelectIdLbl);
            this.Controls.Add(this.PreparedLbl);
            this.Controls.Add(this.NotStartedLbl);
            this.Controls.Add(this.InPrepLbl);
            this.Controls.Add(this.SelectOrdertxt);
            this.Controls.Add(this.PreparedListView);
            this.Controls.Add(this.NotStartedListView);
            this.Controls.Add(this.ServedBtn);
            this.Controls.Add(this.PreparedBtn);
            this.Controls.Add(this.InPreparationBtn);
            this.Controls.Add(this.OrderStatusLbl);
            this.Controls.Add(this.SelectedOrderLbl);
            this.Controls.Add(this.OrderStatusIndicLbl);
            this.Controls.Add(this.Selectedorderindiclbl);
            this.Controls.Add(this.SelectOrderBtn);
            this.Controls.Add(this.InPrepListview);
            this.Controls.Add(this.TitelLbl);
            this.Name = "ItemBereidersUI";
            this.Text = "ItemBereidersUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OrderStatusLbl;
        private Label SelectedOrderLbl;
        private Label OrderStatusIndicLbl;
        private Label Selectedorderindiclbl;
        private Button SelectOrderBtn;
        private ListView InPrepListview;
        private ColumnHeader BesteldItemIdHdr;
        private ColumnHeader BestellingsIdHdr;
        private ColumnHeader CountHdr;
        private ColumnHeader DescriptionHdr;
        private Label TitelLbl;
        private Button InPreparationBtn;
        private Button PreparedBtn;
        private Button ServedBtn;
        private ListView NotStartedListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView PreparedListView;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TextBox SelectOrdertxt;
        private Label InPrepLbl;
        private Label NotStartedLbl;
        private Label PreparedLbl;
        private Label SelectIdLbl;
    }
}