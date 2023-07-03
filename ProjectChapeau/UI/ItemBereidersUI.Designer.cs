namespace UI
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
            this.TitelLbl = new System.Windows.Forms.Label();
            this.InPreparationBtn = new System.Windows.Forms.Button();
            this.PreparedBtn = new System.Windows.Forms.Button();
            this.NotStartedListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SelectOrdertxt = new System.Windows.Forms.TextBox();
            this.InPrepLbl = new System.Windows.Forms.Label();
            this.NotStartedLbl = new System.Windows.Forms.Label();
            this.SelectIdLbl = new System.Windows.Forms.Label();
            this.SearchOnGoingItemsBtn = new System.Windows.Forms.Button();
            this.SearchFinishedItemsBtn = new System.Windows.Forms.Button();
            this.InPrepListview = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.BtnItemBereiderLoguit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderStatusLbl
            // 
            this.OrderStatusLbl.AutoSize = true;
            this.OrderStatusLbl.Location = new System.Drawing.Point(1635, 367);
            this.OrderStatusLbl.Name = "OrderStatusLbl";
            this.OrderStatusLbl.Size = new System.Drawing.Size(17, 25);
            this.OrderStatusLbl.TabIndex = 29;
            this.OrderStatusLbl.Text = " ";
            // 
            // SelectedOrderLbl
            // 
            this.SelectedOrderLbl.AutoSize = true;
            this.SelectedOrderLbl.Location = new System.Drawing.Point(1397, 367);
            this.SelectedOrderLbl.Name = "SelectedOrderLbl";
            this.SelectedOrderLbl.Size = new System.Drawing.Size(17, 25);
            this.SelectedOrderLbl.TabIndex = 28;
            this.SelectedOrderLbl.Text = " ";
            // 
            // OrderStatusIndicLbl
            // 
            this.OrderStatusIndicLbl.AutoSize = true;
            this.OrderStatusIndicLbl.Location = new System.Drawing.Point(1628, 281);
            this.OrderStatusIndicLbl.Name = "OrderStatusIndicLbl";
            this.OrderStatusIndicLbl.Size = new System.Drawing.Size(110, 25);
            this.OrderStatusIndicLbl.TabIndex = 27;
            this.OrderStatusIndicLbl.Text = "Order status";
            // 
            // Selectedorderindiclbl
            // 
            this.Selectedorderindiclbl.AutoSize = true;
            this.Selectedorderindiclbl.Location = new System.Drawing.Point(1378, 281);
            this.Selectedorderindiclbl.Name = "Selectedorderindiclbl";
            this.Selectedorderindiclbl.Size = new System.Drawing.Size(154, 25);
            this.Selectedorderindiclbl.TabIndex = 26;
            this.Selectedorderindiclbl.Text = " Selected order ID\n";
            // 
            // SelectOrderBtn
            // 
            this.SelectOrderBtn.Location = new System.Drawing.Point(214, 823);
            this.SelectOrderBtn.Name = "SelectOrderBtn";
            this.SelectOrderBtn.Size = new System.Drawing.Size(141, 48);
            this.SelectOrderBtn.TabIndex = 25;
            this.SelectOrderBtn.Text = "Select OrderId";
            this.SelectOrderBtn.UseVisualStyleBackColor = true;
            this.SelectOrderBtn.Click += new System.EventHandler(this.SelectOrderBtn_Click);
            // 
            // TitelLbl
            // 
            this.TitelLbl.AutoSize = true;
            this.TitelLbl.Location = new System.Drawing.Point(569, 17);
            this.TitelLbl.Name = "TitelLbl";
            this.TitelLbl.Size = new System.Drawing.Size(0, 25);
            this.TitelLbl.TabIndex = 20;
            // 
            // InPreparationBtn
            // 
            this.InPreparationBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InPreparationBtn.Location = new System.Drawing.Point(1378, 91);
            this.InPreparationBtn.Name = "InPreparationBtn";
            this.InPreparationBtn.Size = new System.Drawing.Size(134, 53);
            this.InPreparationBtn.TabIndex = 30;
            this.InPreparationBtn.Text = "In preparation";
            this.InPreparationBtn.UseVisualStyleBackColor = false;
            this.InPreparationBtn.Click += new System.EventHandler(this.InPreparationBtn_Click);
            // 
            // PreparedBtn
            // 
            this.PreparedBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.PreparedBtn.Location = new System.Drawing.Point(1609, 91);
            this.PreparedBtn.Name = "PreparedBtn";
            this.PreparedBtn.Size = new System.Drawing.Size(129, 53);
            this.PreparedBtn.TabIndex = 31;
            this.PreparedBtn.Text = "Prepared";
            this.PreparedBtn.UseVisualStyleBackColor = false;
            this.PreparedBtn.Click += new System.EventHandler(this.PreparedBtn_Click);
            // 
            // NotStartedListView
            // 
            this.NotStartedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader5,
            this.columnHeader6});
            this.NotStartedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotStartedListView.GridLines = true;
            this.NotStartedListView.Location = new System.Drawing.Point(14, 449);
            this.NotStartedListView.Name = "NotStartedListView";
            this.NotStartedListView.Size = new System.Drawing.Size(1237, 293);
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
            this.columnHeader3.Text = "TableNr";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "";
            this.columnHeader4.Text = "Order Time";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Wait Time";
            this.columnHeader9.Width = 140;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Count";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 400;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 200;
            // 
            // SelectOrdertxt
            // 
            this.SelectOrdertxt.Location = new System.Drawing.Point(11, 833);
            this.SelectOrdertxt.Name = "SelectOrdertxt";
            this.SelectOrdertxt.Size = new System.Drawing.Size(150, 31);
            this.SelectOrdertxt.TabIndex = 35;
            // 
            // InPrepLbl
            // 
            this.InPrepLbl.AutoSize = true;
            this.InPrepLbl.Location = new System.Drawing.Point(29, 52);
            this.InPrepLbl.Name = "InPrepLbl";
            this.InPrepLbl.Size = new System.Drawing.Size(123, 25);
            this.InPrepLbl.TabIndex = 36;
            this.InPrepLbl.Text = "In Preparation";
            // 
            // NotStartedLbl
            // 
            this.NotStartedLbl.AutoSize = true;
            this.NotStartedLbl.Location = new System.Drawing.Point(27, 407);
            this.NotStartedLbl.Name = "NotStartedLbl";
            this.NotStartedLbl.Size = new System.Drawing.Size(98, 25);
            this.NotStartedLbl.TabIndex = 37;
            this.NotStartedLbl.Text = "NotStarted";
            // 
            // SelectIdLbl
            // 
            this.SelectIdLbl.AutoSize = true;
            this.SelectIdLbl.Location = new System.Drawing.Point(11, 804);
            this.SelectIdLbl.Name = "SelectIdLbl";
            this.SelectIdLbl.Size = new System.Drawing.Size(149, 25);
            this.SelectIdLbl.TabIndex = 39;
            this.SelectIdLbl.Text = "Select an OrderId";
            // 
            // SearchOnGoingItemsBtn
            // 
            this.SearchOnGoingItemsBtn.Location = new System.Drawing.Point(1352, 799);
            this.SearchOnGoingItemsBtn.Name = "SearchOnGoingItemsBtn";
            this.SearchOnGoingItemsBtn.Size = new System.Drawing.Size(160, 64);
            this.SearchOnGoingItemsBtn.TabIndex = 40;
            this.SearchOnGoingItemsBtn.Text = "Search InPrep";
            this.SearchOnGoingItemsBtn.UseVisualStyleBackColor = true;
            this.SearchOnGoingItemsBtn.Click += new System.EventHandler(this.SearchOnGoingItemsBtn_Click);
            // 
            // SearchFinishedItemsBtn
            // 
            this.SearchFinishedItemsBtn.Location = new System.Drawing.Point(1584, 799);
            this.SearchFinishedItemsBtn.Name = "SearchFinishedItemsBtn";
            this.SearchFinishedItemsBtn.Size = new System.Drawing.Size(141, 64);
            this.SearchFinishedItemsBtn.TabIndex = 41;
            this.SearchFinishedItemsBtn.Text = "Search Finished";
            this.SearchFinishedItemsBtn.UseVisualStyleBackColor = true;
            this.SearchFinishedItemsBtn.Click += new System.EventHandler(this.SearchFinishedItemsBtn_Click);
            // 
            // InPrepListview
            // 
            this.InPrepListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.InPrepListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InPrepListview.GridLines = true;
            this.InPrepListview.Location = new System.Drawing.Point(14, 98);
            this.InPrepListview.Name = "InPrepListview";
            this.InPrepListview.Size = new System.Drawing.Size(1237, 293);
            this.InPrepListview.TabIndex = 42;
            this.InPrepListview.UseCompatibleStateImageBehavior = false;
            this.InPrepListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Tag = "";
            this.columnHeader7.Text = "OrderId";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Tag = "";
            this.columnHeader8.Text = "OrderNumber";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Tag = "";
            this.columnHeader11.Text = "TableNr";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Tag = "";
            this.columnHeader12.Text = "Order Time";
            this.columnHeader12.Width = 140;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Wait Time";
            this.columnHeader13.Width = 140;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Count";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Name";
            this.columnHeader15.Width = 400;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Description";
            this.columnHeader16.Width = 200;
            // 
            // BtnItemBereiderLoguit
            // 
            this.BtnItemBereiderLoguit.Location = new System.Drawing.Point(1764, 13);
            this.BtnItemBereiderLoguit.Name = "BtnItemBereiderLoguit";
            this.BtnItemBereiderLoguit.Size = new System.Drawing.Size(112, 41);
            this.BtnItemBereiderLoguit.TabIndex = 43;
            this.BtnItemBereiderLoguit.Text = "Logout";
            this.BtnItemBereiderLoguit.UseVisualStyleBackColor = true;
            this.BtnItemBereiderLoguit.Click += new System.EventHandler(this.BtnItemBereiderLoguit_Click);
            // 
            // ItemBereidersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 926);
            this.Controls.Add(this.BtnItemBereiderLoguit);
            this.Controls.Add(this.InPrepListview);
            this.Controls.Add(this.SearchFinishedItemsBtn);
            this.Controls.Add(this.SearchOnGoingItemsBtn);
            this.Controls.Add(this.SelectIdLbl);
            this.Controls.Add(this.NotStartedLbl);
            this.Controls.Add(this.InPrepLbl);
            this.Controls.Add(this.SelectOrdertxt);
            this.Controls.Add(this.NotStartedListView);
            this.Controls.Add(this.PreparedBtn);
            this.Controls.Add(this.InPreparationBtn);
            this.Controls.Add(this.OrderStatusLbl);
            this.Controls.Add(this.SelectedOrderLbl);
            this.Controls.Add(this.OrderStatusIndicLbl);
            this.Controls.Add(this.Selectedorderindiclbl);
            this.Controls.Add(this.SelectOrderBtn);
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
        private Label TitelLbl;
        private Button InPreparationBtn;
        private Button PreparedBtn;
        private ListView NotStartedListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox SelectOrdertxt;
        private Label InPrepLbl;
        private Label NotStartedLbl;
        private Label SelectIdLbl;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button SearchOnGoingItemsBtn;
        private Button SearchFinishedItemsBtn;
        private ListView InPrepListview;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private Button BtnItemBereiderLoguit;
    }
}