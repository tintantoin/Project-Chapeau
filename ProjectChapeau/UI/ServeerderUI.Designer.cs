namespace UI
{
    partial class ServeerderUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServeerderUI));
            picChapeauLogIn = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            DinnerButton = new RadioButton();
            LunchButton = new RadioButton();
            DrinkButton = new RadioButton();
            listViewDinnerItems = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            Dinnerpnl = new Panel();
            Drinkpnl = new Panel();
            AddDrink = new Button();
            AddedDrinklvi = new ListView();
            columnHeader11 = new ColumnHeader();
            listViewDrinkItems = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            AddDinner = new Button();
            addedDinnerlvi = new ListView();
            columnHeader12 = new ColumnHeader();
            pnlDashboard = new Panel();
            Lunchpnl = new Panel();
            AddLunch = new Button();
            addedLunchlvi = new ListView();
            columnHeader10 = new ColumnHeader();
            listViewLunchItems = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)picChapeauLogIn).BeginInit();
            Dinnerpnl.SuspendLayout();
            Drinkpnl.SuspendLayout();
            Lunchpnl.SuspendLayout();
            SuspendLayout();
            // 
            // picChapeauLogIn
            // 
            picChapeauLogIn.Image = (Image)resources.GetObject("picChapeauLogIn.Image");
            picChapeauLogIn.Location = new Point(12, 12);
            picChapeauLogIn.Name = "picChapeauLogIn";
            picChapeauLogIn.Size = new Size(179, 111);
            picChapeauLogIn.TabIndex = 3;
            picChapeauLogIn.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(310, 48);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(217, 48);
            label1.Name = "label1";
            label1.Size = new Size(97, 46);
            label1.TabIndex = 5;
            label1.Text = "Table";
            // 
            // DinnerButton
            // 
            DinnerButton.AutoSize = true;
            DinnerButton.Location = new Point(217, 151);
            DinnerButton.Name = "DinnerButton";
            DinnerButton.Size = new Size(84, 24);
            DinnerButton.TabIndex = 18;
            DinnerButton.TabStop = true;
            DinnerButton.Text = "DINNER";
            DinnerButton.UseVisualStyleBackColor = true;
            DinnerButton.CheckedChanged += DinnerButton_CheckedChanged_1;
            // 
            // LunchButton
            // 
            LunchButton.AutoSize = true;
            LunchButton.Location = new Point(31, 151);
            LunchButton.Name = "LunchButton";
            LunchButton.Size = new Size(78, 24);
            LunchButton.TabIndex = 17;
            LunchButton.TabStop = true;
            LunchButton.Text = "LUNCH";
            LunchButton.UseVisualStyleBackColor = true;
            LunchButton.CheckedChanged += LunchButton_CheckedChanged_1;
            // 
            // DrinkButton
            // 
            DrinkButton.AutoSize = true;
            DrinkButton.Location = new Point(406, 151);
            DrinkButton.Name = "DrinkButton";
            DrinkButton.Size = new Size(82, 24);
            DrinkButton.TabIndex = 19;
            DrinkButton.TabStop = true;
            DrinkButton.Text = "DRINKS";
            DrinkButton.UseVisualStyleBackColor = true;
            DrinkButton.CheckedChanged += DrinkButton_CheckedChanged_1;
            // 
            // listViewDinnerItems
            // 
            listViewDinnerItems.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9 });
            listViewDinnerItems.FullRowSelect = true;
            listViewDinnerItems.Location = new Point(0, 3);
            listViewDinnerItems.Name = "listViewDinnerItems";
            listViewDinnerItems.Size = new Size(448, 499);
            listViewDinnerItems.TabIndex = 0;
            listViewDinnerItems.UseCompatibleStateImageBehavior = false;
            listViewDinnerItems.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Name";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Price";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "MenuType";
            columnHeader9.Width = 200;
            // 
            // Dinnerpnl
            // 
            Dinnerpnl.Controls.Add(AddDinner);
            Dinnerpnl.Controls.Add(addedDinnerlvi);
            Dinnerpnl.Controls.Add(listViewDinnerItems);
            Dinnerpnl.Location = new Point(41, 337);
            Dinnerpnl.Name = "Dinnerpnl";
            Dinnerpnl.Size = new Size(568, 846);
            Dinnerpnl.TabIndex = 16;
            // 
            // Drinkpnl
            // 
            Drinkpnl.Controls.Add(AddDrink);
            Drinkpnl.Controls.Add(AddedDrinklvi);
            Drinkpnl.Controls.Add(listViewDrinkItems);
            Drinkpnl.Location = new Point(620, 519);
            Drinkpnl.Name = "Drinkpnl";
            Drinkpnl.Size = new Size(568, 844);
            Drinkpnl.TabIndex = 17;
            // 
            // AddDrink
            // 
            AddDrink.Location = new Point(442, 742);
            AddDrink.Name = "AddDrink";
            AddDrink.Size = new Size(114, 43);
            AddDrink.TabIndex = 2;
            AddDrink.Text = "add";
            AddDrink.UseVisualStyleBackColor = true;
            AddDrink.Click += button2_Click;
            // 
            // AddedDrinklvi
            // 
            AddedDrinklvi.Columns.AddRange(new ColumnHeader[] { columnHeader11 });
            AddedDrinklvi.Location = new Point(0, 508);
            AddedDrinklvi.Name = "AddedDrinklvi";
            AddedDrinklvi.Size = new Size(448, 215);
            AddedDrinklvi.TabIndex = 1;
            AddedDrinklvi.UseCompatibleStateImageBehavior = false;
            AddedDrinklvi.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Name";
            columnHeader11.Width = 250;
            // 
            // listViewDrinkItems
            // 
            listViewDrinkItems.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listViewDrinkItems.FullRowSelect = true;
            listViewDrinkItems.GridLines = true;
            listViewDrinkItems.Location = new Point(0, 0);
            listViewDrinkItems.Name = "listViewDrinkItems";
            listViewDrinkItems.Size = new Size(448, 499);
            listViewDrinkItems.TabIndex = 13;
            listViewDrinkItems.UseCompatibleStateImageBehavior = false;
            listViewDrinkItems.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Name";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Price";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "MenuType";
            columnHeader6.Width = 200;
            // 
            // AddDinner
            // 
            AddDinner.Location = new Point(442, 742);
            AddDinner.Name = "AddDinner";
            AddDinner.Size = new Size(114, 43);
            AddDinner.TabIndex = 2;
            AddDinner.Text = "add";
            AddDinner.UseVisualStyleBackColor = true;
            AddDinner.Click += AddItemButton_Click;
            // 
            // addedDinnerlvi
            // 
            addedDinnerlvi.Columns.AddRange(new ColumnHeader[] { columnHeader12 });
            addedDinnerlvi.Location = new Point(0, 508);
            addedDinnerlvi.Name = "addedDinnerlvi";
            addedDinnerlvi.Size = new Size(448, 215);
            addedDinnerlvi.TabIndex = 1;
            addedDinnerlvi.UseCompatibleStateImageBehavior = false;
            addedDinnerlvi.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Price";
            columnHeader12.Width = 250;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Location = new Point(615, 15);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(532, 423);
            pnlDashboard.TabIndex = 21;
            // 
            // Lunchpnl
            // 
            Lunchpnl.Controls.Add(AddLunch);
            Lunchpnl.Controls.Add(addedLunchlvi);
            Lunchpnl.Controls.Add(listViewLunchItems);
            Lunchpnl.Location = new Point(632, 444);
            Lunchpnl.Name = "Lunchpnl";
            Lunchpnl.Size = new Size(568, 847);
            Lunchpnl.TabIndex = 17;
            // 
            // AddLunch
            // 
            AddLunch.Location = new Point(442, 742);
            AddLunch.Name = "AddLunch";
            AddLunch.Size = new Size(114, 43);
            AddLunch.TabIndex = 2;
            AddLunch.Text = "add";
            AddLunch.UseVisualStyleBackColor = true;
            AddLunch.Click += AddLunch_Click;
            // 
            // addedLunchlvi
            // 
            addedLunchlvi.Columns.AddRange(new ColumnHeader[] { columnHeader10 });
            addedLunchlvi.Location = new Point(0, 508);
            addedLunchlvi.Name = "addedLunchlvi";
            addedLunchlvi.Size = new Size(448, 215);
            addedLunchlvi.TabIndex = 1;
            addedLunchlvi.UseCompatibleStateImageBehavior = false;
            addedLunchlvi.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Price";
            columnHeader10.Width = 250;
            // 
            // listViewLunchItems
            // 
            listViewLunchItems.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewLunchItems.FullRowSelect = true;
            listViewLunchItems.Location = new Point(0, 3);
            listViewLunchItems.Name = "listViewLunchItems";
            listViewLunchItems.Size = new Size(448, 499);
            listViewLunchItems.TabIndex = 0;
            listViewLunchItems.UseCompatibleStateImageBehavior = false;
            listViewLunchItems.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "MenuType";
            columnHeader3.Width = 200;
            // 
            // ServeerderUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 1055);
            Controls.Add(Drinkpnl);
            Controls.Add(Lunchpnl);
            Controls.Add(pnlDashboard);
            Controls.Add(Dinnerpnl);
            Controls.Add(DrinkButton);
            Controls.Add(label2);
            Controls.Add(DinnerButton);
            Controls.Add(LunchButton);
            Controls.Add(label1);
            Controls.Add(picChapeauLogIn);
            Name = "ServeerderUI";
            Text = "ServeerderUI";
            Load += ServeerderUI_Load;
            ((System.ComponentModel.ISupportInitialize)picChapeauLogIn).EndInit();
            Dinnerpnl.ResumeLayout(false);
            Drinkpnl.ResumeLayout(false);
            Lunchpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picChapeauLogIn;
        private Label label2;
        private Label label1;
        private RadioButton DinnerButton;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ListView listViewDinnerItems;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Panel Dinnerpnl;
        private Panel pnlDashboard;
        private RadioButton LunchButton;
        private RadioButton DrinkButton;
        private ListView addedDinnerlvi;
        private Button AddDinner;
        private Panel Lunchpnl;
        private Button AddLunch;
        private ListView addedLunchlvi;
        private ListView listViewLunchItems;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader10;
        private ListView listViewDrinkItems;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView AddedDrinklvi;
        private ColumnHeader columnHeader11;
        private Button AddDrink;
        private Panel Drinkpnl;
    }
}