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
            OrderStatusLbl = new Label();
            SelectedOrderLbl = new Label();
            OrderStatusIndicLbl = new Label();
            Selectedorderindiclbl = new Label();
            SelectOrderBtn = new Button();
            InPrepListview = new ListView();
            BesteldItemIdHdr = new ColumnHeader();
            BestellingsIdHdr = new ColumnHeader();
            CountHdr = new ColumnHeader();
            DescriptionHdr = new ColumnHeader();
            TitelLbl = new Label();
            InPreparationBtn = new Button();
            PreparedBtn = new Button();
            ServedBtn = new Button();
            NotStartedListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            PreparedListView = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            SelectOrdertxt = new TextBox();
            InPrepLbl = new Label();
            NotStartedLbl = new Label();
            PreparedLbl = new Label();
            SelectIdLbl = new Label();
            btnLogOutItemBereiders = new Button();
            SuspendLayout();
            // 
            // OrderStatusLbl
            // 
            OrderStatusLbl.AutoSize = true;
            OrderStatusLbl.Location = new Point(694, 212);
            OrderStatusLbl.Margin = new Padding(2, 0, 2, 0);
            OrderStatusLbl.Name = "OrderStatusLbl";
            OrderStatusLbl.Size = new Size(10, 15);
            OrderStatusLbl.TabIndex = 29;
            OrderStatusLbl.Text = " ";
            // 
            // SelectedOrderLbl
            // 
            SelectedOrderLbl.AutoSize = true;
            SelectedOrderLbl.Location = new Point(527, 212);
            SelectedOrderLbl.Margin = new Padding(2, 0, 2, 0);
            SelectedOrderLbl.Name = "SelectedOrderLbl";
            SelectedOrderLbl.Size = new Size(10, 15);
            SelectedOrderLbl.TabIndex = 28;
            SelectedOrderLbl.Text = " ";
            // 
            // OrderStatusIndicLbl
            // 
            OrderStatusIndicLbl.AutoSize = true;
            OrderStatusIndicLbl.Location = new Point(676, 180);
            OrderStatusIndicLbl.Margin = new Padding(2, 0, 2, 0);
            OrderStatusIndicLbl.Name = "OrderStatusIndicLbl";
            OrderStatusIndicLbl.Size = new Size(71, 15);
            OrderStatusIndicLbl.TabIndex = 27;
            OrderStatusIndicLbl.Text = "Order status";
            // 
            // Selectedorderindiclbl
            // 
            Selectedorderindiclbl.AutoSize = true;
            Selectedorderindiclbl.Location = new Point(501, 180);
            Selectedorderindiclbl.Margin = new Padding(2, 0, 2, 0);
            Selectedorderindiclbl.Name = "Selectedorderindiclbl";
            Selectedorderindiclbl.Size = new Size(99, 15);
            Selectedorderindiclbl.TabIndex = 26;
            Selectedorderindiclbl.Text = " Selected order ID\n";
            // 
            // SelectOrderBtn
            // 
            SelectOrderBtn.Location = new Point(150, 517);
            SelectOrderBtn.Margin = new Padding(2, 2, 2, 2);
            SelectOrderBtn.Name = "SelectOrderBtn";
            SelectOrderBtn.Size = new Size(99, 29);
            SelectOrderBtn.TabIndex = 25;
            SelectOrderBtn.Text = "Select OrderId";
            SelectOrderBtn.UseVisualStyleBackColor = true;
            SelectOrderBtn.Click += SelectOrderBtn_Click;
            // 
            // InPrepListview
            // 
            InPrepListview.Columns.AddRange(new ColumnHeader[] { BesteldItemIdHdr, BestellingsIdHdr, CountHdr, DescriptionHdr });
            InPrepListview.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            InPrepListview.GridLines = true;
            InPrepListview.Location = new Point(8, 59);
            InPrepListview.Margin = new Padding(2, 2, 2, 2);
            InPrepListview.Name = "InPrepListview";
            InPrepListview.Size = new Size(466, 123);
            InPrepListview.TabIndex = 21;
            InPrepListview.UseCompatibleStateImageBehavior = false;
            InPrepListview.View = View.Details;
            // 
            // BesteldItemIdHdr
            // 
            BesteldItemIdHdr.Tag = "";
            BesteldItemIdHdr.Text = "OrderId";
            BesteldItemIdHdr.Width = 80;
            // 
            // BestellingsIdHdr
            // 
            BestellingsIdHdr.Tag = "";
            BestellingsIdHdr.Text = "OrderNumber";
            BestellingsIdHdr.Width = 120;
            // 
            // CountHdr
            // 
            CountHdr.Tag = "";
            CountHdr.Text = "Count";
            // 
            // DescriptionHdr
            // 
            DescriptionHdr.Tag = "";
            DescriptionHdr.Text = "Description";
            DescriptionHdr.Width = 400;
            // 
            // TitelLbl
            // 
            TitelLbl.AutoSize = true;
            TitelLbl.Location = new Point(398, 10);
            TitelLbl.Margin = new Padding(2, 0, 2, 0);
            TitelLbl.Name = "TitelLbl";
            TitelLbl.Size = new Size(0, 15);
            TitelLbl.TabIndex = 20;
            // 
            // InPreparationBtn
            // 
            InPreparationBtn.BackColor = SystemColors.ControlLightLight;
            InPreparationBtn.Location = new Point(501, 59);
            InPreparationBtn.Margin = new Padding(2, 2, 2, 2);
            InPreparationBtn.Name = "InPreparationBtn";
            InPreparationBtn.Size = new Size(94, 32);
            InPreparationBtn.TabIndex = 30;
            InPreparationBtn.Text = "In preparation";
            InPreparationBtn.UseVisualStyleBackColor = false;
            InPreparationBtn.Click += InPreparationBtn_Click;
            // 
            // PreparedBtn
            // 
            PreparedBtn.BackColor = Color.DarkOrange;
            PreparedBtn.Location = new Point(599, 59);
            PreparedBtn.Margin = new Padding(2, 2, 2, 2);
            PreparedBtn.Name = "PreparedBtn";
            PreparedBtn.Size = new Size(90, 32);
            PreparedBtn.TabIndex = 31;
            PreparedBtn.Text = "Prepared";
            PreparedBtn.UseVisualStyleBackColor = false;
            PreparedBtn.Click += PreparedBtn_Click;
            // 
            // ServedBtn
            // 
            ServedBtn.BackColor = Color.DarkSeaGreen;
            ServedBtn.Location = new Point(694, 59);
            ServedBtn.Margin = new Padding(2, 2, 2, 2);
            ServedBtn.Name = "ServedBtn";
            ServedBtn.Size = new Size(86, 32);
            ServedBtn.TabIndex = 32;
            ServedBtn.Text = "Served";
            ServedBtn.UseVisualStyleBackColor = false;
            ServedBtn.Click += ServedBtn_Click;
            // 
            // NotStartedListView
            // 
            NotStartedListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            NotStartedListView.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            NotStartedListView.GridLines = true;
            NotStartedListView.Location = new Point(8, 212);
            NotStartedListView.Margin = new Padding(2, 2, 2, 2);
            NotStartedListView.Name = "NotStartedListView";
            NotStartedListView.Size = new Size(466, 123);
            NotStartedListView.TabIndex = 33;
            NotStartedListView.UseCompatibleStateImageBehavior = false;
            NotStartedListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "";
            columnHeader1.Text = "OrderId";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Tag = "";
            columnHeader2.Text = "OrderNumber";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Tag = "";
            columnHeader3.Text = "Count";
            // 
            // columnHeader4
            // 
            columnHeader4.Tag = "";
            columnHeader4.Text = "Description";
            columnHeader4.Width = 400;
            // 
            // PreparedListView
            // 
            PreparedListView.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            PreparedListView.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            PreparedListView.GridLines = true;
            PreparedListView.Location = new Point(8, 373);
            PreparedListView.Margin = new Padding(2, 2, 2, 2);
            PreparedListView.Name = "PreparedListView";
            PreparedListView.Size = new Size(466, 123);
            PreparedListView.TabIndex = 34;
            PreparedListView.UseCompatibleStateImageBehavior = false;
            PreparedListView.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Tag = "";
            columnHeader5.Text = "OrderId";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Tag = "";
            columnHeader6.Text = "OrderNumber";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Tag = "";
            columnHeader7.Text = "Count";
            // 
            // columnHeader8
            // 
            columnHeader8.Tag = "";
            columnHeader8.Text = "Description";
            columnHeader8.Width = 400;
            // 
            // SelectOrdertxt
            // 
            SelectOrdertxt.Location = new Point(8, 523);
            SelectOrdertxt.Margin = new Padding(2, 2, 2, 2);
            SelectOrdertxt.Name = "SelectOrdertxt";
            SelectOrdertxt.Size = new Size(106, 23);
            SelectOrdertxt.TabIndex = 35;
            // 
            // InPrepLbl
            // 
            InPrepLbl.AutoSize = true;
            InPrepLbl.Location = new Point(20, 31);
            InPrepLbl.Margin = new Padding(2, 0, 2, 0);
            InPrepLbl.Name = "InPrepLbl";
            InPrepLbl.Size = new Size(81, 15);
            InPrepLbl.TabIndex = 36;
            InPrepLbl.Text = "In Preparation";
            // 
            // NotStartedLbl
            // 
            NotStartedLbl.AutoSize = true;
            NotStartedLbl.Location = new Point(20, 189);
            NotStartedLbl.Margin = new Padding(2, 0, 2, 0);
            NotStartedLbl.Name = "NotStartedLbl";
            NotStartedLbl.Size = new Size(64, 15);
            NotStartedLbl.TabIndex = 37;
            NotStartedLbl.Text = "NotStarted";
            // 
            // PreparedLbl
            // 
            PreparedLbl.AutoSize = true;
            PreparedLbl.Location = new Point(20, 348);
            PreparedLbl.Margin = new Padding(2, 0, 2, 0);
            PreparedLbl.Name = "PreparedLbl";
            PreparedLbl.Size = new Size(54, 15);
            PreparedLbl.TabIndex = 38;
            PreparedLbl.Text = "Prepared";
            // 
            // SelectIdLbl
            // 
            SelectIdLbl.AutoSize = true;
            SelectIdLbl.Location = new Point(8, 506);
            SelectIdLbl.Margin = new Padding(2, 0, 2, 0);
            SelectIdLbl.Name = "SelectIdLbl";
            SelectIdLbl.Size = new Size(97, 15);
            SelectIdLbl.TabIndex = 39;
            SelectIdLbl.Text = "Select an OrderId";
            // 
            // btnLogOutItemBereiders
            // 
            btnLogOutItemBereiders.Location = new Point(724, 24);
            btnLogOutItemBereiders.Margin = new Padding(3, 2, 3, 2);
            btnLogOutItemBereiders.Name = "btnLogOutItemBereiders";
            btnLogOutItemBereiders.Size = new Size(82, 22);
            btnLogOutItemBereiders.TabIndex = 40;
            btnLogOutItemBereiders.Text = "Log out";
            btnLogOutItemBereiders.UseVisualStyleBackColor = true;
            btnLogOutItemBereiders.Click += btnLogOutItemBereiders_Click;
            // 
            // ItemBereidersUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 553);
            Controls.Add(btnLogOutItemBereiders);
            Controls.Add(SelectIdLbl);
            Controls.Add(PreparedLbl);
            Controls.Add(NotStartedLbl);
            Controls.Add(InPrepLbl);
            Controls.Add(SelectOrdertxt);
            Controls.Add(PreparedListView);
            Controls.Add(NotStartedListView);
            Controls.Add(ServedBtn);
            Controls.Add(PreparedBtn);
            Controls.Add(InPreparationBtn);
            Controls.Add(OrderStatusLbl);
            Controls.Add(SelectedOrderLbl);
            Controls.Add(OrderStatusIndicLbl);
            Controls.Add(Selectedorderindiclbl);
            Controls.Add(SelectOrderBtn);
            Controls.Add(InPrepListview);
            Controls.Add(TitelLbl);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ItemBereidersUI";
            Text = "ItemBereidersUI";
            Load += ItemBereidersUI_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnLogOutItemBereiders;
    }
}