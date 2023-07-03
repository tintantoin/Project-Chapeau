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
            label1 = new Label();
            menuListView = new ListView();
            ColumnName = new ColumnHeader();
            ColumnPrijs = new ColumnHeader();
            ColumnVoorraad = new ColumnHeader();
            lunchButton = new Button();
            dinnerButton = new Button();
            drinkButton = new Button();
            menuGroupBox = new GroupBox();
            addMenuItemToOrderButton = new Button();
            orderGroupBox = new GroupBox();
            clearOrderButton = new Button();
            removeAllOrderButton = new Button();
            commentGroupBox = new GroupBox();
            orderCommentTextBox = new TextBox();
            finishOrderButton = new Button();
            addCommentButton = new Button();
            decreaseOrderButton = new Button();
            orderListView = new ListView();
            OrderColumnAaantal = new ColumnHeader();
            OrderColumnName = new ColumnHeader();
            OrderColumnPrice = new ColumnHeader();
            OrderColumnType = new ColumnHeader();
            logoPictureBox = new PictureBox();
            menuGroupBox.SuspendLayout();
            orderGroupBox.SuspendLayout();
            commentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 37);
            label1.TabIndex = 5;
            label1.Text = "Serveer tafel ";
            // 
            // menuListView
            // 
            menuListView.Columns.AddRange(new ColumnHeader[] { ColumnName, ColumnPrijs, ColumnVoorraad });
            menuListView.FullRowSelect = true;
            menuListView.Location = new Point(7, 76);
            menuListView.Margin = new Padding(3, 2, 3, 2);
            menuListView.Name = "menuListView";
            menuListView.Size = new Size(462, 270);
            menuListView.TabIndex = 0;
            menuListView.UseCompatibleStateImageBehavior = false;
            menuListView.View = View.Details;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 250;
            // 
            // ColumnPrijs
            // 
            ColumnPrijs.Text = "Price";
            // 
            // ColumnVoorraad
            // 
            ColumnVoorraad.Text = "Voorraad";
            // 
            // lunchButton
            // 
            lunchButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lunchButton.Location = new Point(7, 22);
            lunchButton.Name = "lunchButton";
            lunchButton.Size = new Size(150, 49);
            lunchButton.TabIndex = 22;
            lunchButton.Text = "Lunch";
            lunchButton.UseVisualStyleBackColor = true;
            lunchButton.Click += lunchButton_Click;
            // 
            // dinnerButton
            // 
            dinnerButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dinnerButton.Location = new Point(163, 22);
            dinnerButton.Name = "dinnerButton";
            dinnerButton.Size = new Size(150, 49);
            dinnerButton.TabIndex = 23;
            dinnerButton.Text = "Dinner";
            dinnerButton.UseVisualStyleBackColor = true;
            dinnerButton.Click += dinnerButton_Click;
            // 
            // drinkButton
            // 
            drinkButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            drinkButton.Location = new Point(319, 22);
            drinkButton.Name = "drinkButton";
            drinkButton.Size = new Size(150, 49);
            drinkButton.TabIndex = 24;
            drinkButton.Text = "Drinks";
            drinkButton.UseVisualStyleBackColor = true;
            drinkButton.Click += drinkButton_Click;
            // 
            // menuGroupBox
            // 
            menuGroupBox.Controls.Add(addMenuItemToOrderButton);
            menuGroupBox.Controls.Add(lunchButton);
            menuGroupBox.Controls.Add(drinkButton);
            menuGroupBox.Controls.Add(menuListView);
            menuGroupBox.Controls.Add(dinnerButton);
            menuGroupBox.Location = new Point(10, 65);
            menuGroupBox.Name = "menuGroupBox";
            menuGroupBox.Size = new Size(476, 390);
            menuGroupBox.TabIndex = 25;
            menuGroupBox.TabStop = false;
            menuGroupBox.Text = "Menu";
            // 
            // addMenuItemToOrderButton
            // 
            addMenuItemToOrderButton.BackColor = Color.AntiqueWhite;
            addMenuItemToOrderButton.Location = new Point(6, 351);
            addMenuItemToOrderButton.Name = "addMenuItemToOrderButton";
            addMenuItemToOrderButton.Size = new Size(463, 33);
            addMenuItemToOrderButton.TabIndex = 25;
            addMenuItemToOrderButton.Text = "Add to Order";
            addMenuItemToOrderButton.UseVisualStyleBackColor = false;
            addMenuItemToOrderButton.Click += addMenuItemToOrderButton_Click;
            // 
            // orderGroupBox
            // 
            orderGroupBox.Controls.Add(clearOrderButton);
            orderGroupBox.Controls.Add(removeAllOrderButton);
            orderGroupBox.Controls.Add(commentGroupBox);
            orderGroupBox.Controls.Add(finishOrderButton);
            orderGroupBox.Controls.Add(addCommentButton);
            orderGroupBox.Controls.Add(decreaseOrderButton);
            orderGroupBox.Controls.Add(orderListView);
            orderGroupBox.Location = new Point(10, 461);
            orderGroupBox.Name = "orderGroupBox";
            orderGroupBox.Size = new Size(476, 347);
            orderGroupBox.TabIndex = 26;
            orderGroupBox.TabStop = false;
            orderGroupBox.Text = "Order";
            // 
            // clearOrderButton
            // 
            clearOrderButton.BackColor = Color.OrangeRed;
            clearOrderButton.Location = new Point(192, 308);
            clearOrderButton.Name = "clearOrderButton";
            clearOrderButton.Size = new Size(64, 33);
            clearOrderButton.TabIndex = 33;
            clearOrderButton.Text = "Clear";
            clearOrderButton.UseVisualStyleBackColor = false;
            clearOrderButton.Click += clearOrderButton_Click;
            // 
            // removeAllOrderButton
            // 
            removeAllOrderButton.BackColor = Color.Tomato;
            removeAllOrderButton.Location = new Point(98, 308);
            removeAllOrderButton.Name = "removeAllOrderButton";
            removeAllOrderButton.Size = new Size(88, 33);
            removeAllOrderButton.TabIndex = 32;
            removeAllOrderButton.Text = "Remove All";
            removeAllOrderButton.UseVisualStyleBackColor = false;
            removeAllOrderButton.Click += removeAllOrderButton_Click;
            // 
            // commentGroupBox
            // 
            commentGroupBox.Controls.Add(orderCommentTextBox);
            commentGroupBox.Location = new Point(7, 20);
            commentGroupBox.Name = "commentGroupBox";
            commentGroupBox.Size = new Size(463, 282);
            commentGroupBox.TabIndex = 31;
            commentGroupBox.TabStop = false;
            commentGroupBox.Text = "Comment";
            commentGroupBox.Visible = false;
            // 
            // orderCommentTextBox
            // 
            orderCommentTextBox.Dock = DockStyle.Fill;
            orderCommentTextBox.Location = new Point(3, 19);
            orderCommentTextBox.Multiline = true;
            orderCommentTextBox.Name = "orderCommentTextBox";
            orderCommentTextBox.ScrollBars = ScrollBars.Both;
            orderCommentTextBox.Size = new Size(457, 260);
            orderCommentTextBox.TabIndex = 30;
            // 
            // finishOrderButton
            // 
            finishOrderButton.BackColor = Color.LightGreen;
            finishOrderButton.Location = new Point(383, 308);
            finishOrderButton.Name = "finishOrderButton";
            finishOrderButton.Size = new Size(87, 33);
            finishOrderButton.TabIndex = 29;
            finishOrderButton.Text = "Finish";
            finishOrderButton.UseVisualStyleBackColor = false;
            finishOrderButton.Click += finishOrderButton_Click;
            // 
            // addCommentButton
            // 
            addCommentButton.BackColor = Color.AntiqueWhite;
            addCommentButton.Location = new Point(262, 308);
            addCommentButton.Name = "addCommentButton";
            addCommentButton.Size = new Size(115, 33);
            addCommentButton.TabIndex = 28;
            addCommentButton.Text = "Comment";
            addCommentButton.UseVisualStyleBackColor = false;
            addCommentButton.Click += addCommentButton_Click;
            // 
            // decreaseOrderButton
            // 
            decreaseOrderButton.BackColor = Color.LightSalmon;
            decreaseOrderButton.Location = new Point(10, 308);
            decreaseOrderButton.Name = "decreaseOrderButton";
            decreaseOrderButton.Size = new Size(82, 33);
            decreaseOrderButton.TabIndex = 27;
            decreaseOrderButton.Text = "Remove 1";
            decreaseOrderButton.UseVisualStyleBackColor = false;
            decreaseOrderButton.Click += decreaseOrderButton_Click;
            // 
            // orderListView
            // 
            orderListView.Columns.AddRange(new ColumnHeader[] { OrderColumnAaantal, OrderColumnName, OrderColumnPrice, OrderColumnType });
            orderListView.FullRowSelect = true;
            orderListView.Location = new Point(8, 21);
            orderListView.Margin = new Padding(3, 2, 3, 2);
            orderListView.MultiSelect = false;
            orderListView.Name = "orderListView";
            orderListView.Size = new Size(462, 282);
            orderListView.TabIndex = 26;
            orderListView.UseCompatibleStateImageBehavior = false;
            orderListView.View = View.Details;
            // 
            // OrderColumnAaantal
            // 
            OrderColumnAaantal.Text = "Aantal";
            OrderColumnAaantal.Width = 50;
            // 
            // OrderColumnName
            // 
            OrderColumnName.Text = "Naam";
            OrderColumnName.Width = 200;
            // 
            // OrderColumnPrice
            // 
            OrderColumnPrice.Text = "Prijs";
            OrderColumnPrice.Width = 80;
            // 
            // OrderColumnType
            // 
            OrderColumnType.Text = "Type";
            OrderColumnType.Width = 100;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(10, 9);
            logoPictureBox.Margin = new Padding(3, 2, 3, 2);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(103, 51);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 28;
            logoPictureBox.TabStop = false;
            // 
            // ServeerderUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 806);
            Controls.Add(logoPictureBox);
            Controls.Add(orderGroupBox);
            Controls.Add(menuGroupBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ServeerderUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServeerderUI";
            menuGroupBox.ResumeLayout(false);
            orderGroupBox.ResumeLayout(false);
            commentGroupBox.ResumeLayout(false);
            commentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ListView menuListView;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnPrijs;
        private Button lunchButton;
        private Button dinnerButton;
        private Button drinkButton;
        private GroupBox menuGroupBox;
        private GroupBox orderGroupBox;
        private Button addMenuItemToOrderButton;
        private ListView orderListView;
        private ColumnHeader OrderColumnAaantal;
        private ColumnHeader OrderColumnName;
        private ColumnHeader OrderColumnPrice;
        private Button addCommentButton;
        private Button decreaseOrderButton;
        private Button finishOrderButton;
        private TextBox orderCommentTextBox;
        private GroupBox commentGroupBox;
        private PictureBox logoPictureBox;
        private ColumnHeader ColumnVoorraad;
        private ColumnHeader OrderColumnType;
        private Button clearOrderButton;
        private Button removeAllOrderButton;
    }
}