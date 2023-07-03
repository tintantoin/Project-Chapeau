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
            this.label1 = new System.Windows.Forms.Label();
            this.menuListView = new System.Windows.Forms.ListView();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnPrijs = new System.Windows.Forms.ColumnHeader();
            this.ColumnVoorraad = new System.Windows.Forms.ColumnHeader();
            this.lunchButton = new System.Windows.Forms.Button();
            this.dinnerButton = new System.Windows.Forms.Button();
            this.drinkButton = new System.Windows.Forms.Button();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.addMenuItemToOrderButton = new System.Windows.Forms.Button();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.clearOrderButton = new System.Windows.Forms.Button();
            this.removeAllOrderButton = new System.Windows.Forms.Button();
            this.commentGroupBox = new System.Windows.Forms.GroupBox();
            this.orderCommentTextBox = new System.Windows.Forms.TextBox();
            this.finishOrderButton = new System.Windows.Forms.Button();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.decreaseOrderButton = new System.Windows.Forms.Button();
            this.orderListView = new System.Windows.Forms.ListView();
            this.OrderColumnAaantal = new System.Windows.Forms.ColumnHeader();
            this.OrderColumnName = new System.Windows.Forms.ColumnHeader();
            this.OrderColumnPrice = new System.Windows.Forms.ColumnHeader();
            this.OrderColumnType = new System.Windows.Forms.ColumnHeader();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.BtnBackServeerderUI = new System.Windows.Forms.Button();
            this.menuGroupBox.SuspendLayout();
            this.orderGroupBox.SuspendLayout();
            this.commentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serveer tafel ";
            // 
            // menuListView
            // 
            this.menuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnPrijs,
            this.ColumnVoorraad});
            this.menuListView.FullRowSelect = true;
            this.menuListView.Location = new System.Drawing.Point(10, 127);
            this.menuListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuListView.Name = "menuListView";
            this.menuListView.Size = new System.Drawing.Size(658, 447);
            this.menuListView.TabIndex = 0;
            this.menuListView.UseCompatibleStateImageBehavior = false;
            this.menuListView.View = System.Windows.Forms.View.Details;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 250;
            // 
            // ColumnPrijs
            // 
            this.ColumnPrijs.Text = "Price";
            // 
            // ColumnVoorraad
            // 
            this.ColumnVoorraad.Text = "Voorraad";
            // 
            // lunchButton
            // 
            this.lunchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchButton.Location = new System.Drawing.Point(10, 37);
            this.lunchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(214, 82);
            this.lunchButton.TabIndex = 22;
            this.lunchButton.Text = "Lunch";
            this.lunchButton.UseVisualStyleBackColor = true;
            // 
            // dinnerButton
            // 
            this.dinnerButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinnerButton.Location = new System.Drawing.Point(233, 37);
            this.dinnerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dinnerButton.Name = "dinnerButton";
            this.dinnerButton.Size = new System.Drawing.Size(214, 82);
            this.dinnerButton.TabIndex = 23;
            this.dinnerButton.Text = "Dinner";
            this.dinnerButton.UseVisualStyleBackColor = true;
            // 
            // drinkButton
            // 
            this.drinkButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drinkButton.Location = new System.Drawing.Point(456, 37);
            this.drinkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(214, 82);
            this.drinkButton.TabIndex = 24;
            this.drinkButton.Text = "Drinks";
            this.drinkButton.UseVisualStyleBackColor = true;
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.addMenuItemToOrderButton);
            this.menuGroupBox.Controls.Add(this.lunchButton);
            this.menuGroupBox.Controls.Add(this.drinkButton);
            this.menuGroupBox.Controls.Add(this.menuListView);
            this.menuGroupBox.Controls.Add(this.dinnerButton);
            this.menuGroupBox.Location = new System.Drawing.Point(14, 108);
            this.menuGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuGroupBox.Size = new System.Drawing.Size(680, 650);
            this.menuGroupBox.TabIndex = 25;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu";
            // 
            // addMenuItemToOrderButton
            // 
            this.addMenuItemToOrderButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addMenuItemToOrderButton.Location = new System.Drawing.Point(9, 585);
            this.addMenuItemToOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addMenuItemToOrderButton.Name = "addMenuItemToOrderButton";
            this.addMenuItemToOrderButton.Size = new System.Drawing.Size(661, 55);
            this.addMenuItemToOrderButton.TabIndex = 25;
            this.addMenuItemToOrderButton.Text = "Add to Order";
            this.addMenuItemToOrderButton.UseVisualStyleBackColor = false;
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.clearOrderButton);
            this.orderGroupBox.Controls.Add(this.removeAllOrderButton);
            this.orderGroupBox.Controls.Add(this.commentGroupBox);
            this.orderGroupBox.Controls.Add(this.finishOrderButton);
            this.orderGroupBox.Controls.Add(this.addCommentButton);
            this.orderGroupBox.Controls.Add(this.decreaseOrderButton);
            this.orderGroupBox.Controls.Add(this.orderListView);
            this.orderGroupBox.Location = new System.Drawing.Point(14, 768);
            this.orderGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderGroupBox.Size = new System.Drawing.Size(680, 578);
            this.orderGroupBox.TabIndex = 26;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Order";
            // 
            // clearOrderButton
            // 
            this.clearOrderButton.BackColor = System.Drawing.Color.OrangeRed;
            this.clearOrderButton.Location = new System.Drawing.Point(274, 513);
            this.clearOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(91, 55);
            this.clearOrderButton.TabIndex = 33;
            this.clearOrderButton.Text = "Clear";
            this.clearOrderButton.UseVisualStyleBackColor = false;
            // 
            // removeAllOrderButton
            // 
            this.removeAllOrderButton.BackColor = System.Drawing.Color.Tomato;
            this.removeAllOrderButton.Location = new System.Drawing.Point(140, 513);
            this.removeAllOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeAllOrderButton.Name = "removeAllOrderButton";
            this.removeAllOrderButton.Size = new System.Drawing.Size(126, 55);
            this.removeAllOrderButton.TabIndex = 32;
            this.removeAllOrderButton.Text = "Remove All";
            this.removeAllOrderButton.UseVisualStyleBackColor = false;
            // 
            // commentGroupBox
            // 
            this.commentGroupBox.Controls.Add(this.orderCommentTextBox);
            this.commentGroupBox.Location = new System.Drawing.Point(10, 33);
            this.commentGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentGroupBox.Name = "commentGroupBox";
            this.commentGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentGroupBox.Size = new System.Drawing.Size(661, 470);
            this.commentGroupBox.TabIndex = 31;
            this.commentGroupBox.TabStop = false;
            this.commentGroupBox.Text = "Comment";
            this.commentGroupBox.Visible = false;
            // 
            // orderCommentTextBox
            // 
            this.orderCommentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderCommentTextBox.Location = new System.Drawing.Point(4, 29);
            this.orderCommentTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderCommentTextBox.Multiline = true;
            this.orderCommentTextBox.Name = "orderCommentTextBox";
            this.orderCommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.orderCommentTextBox.Size = new System.Drawing.Size(653, 436);
            this.orderCommentTextBox.TabIndex = 30;
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.BackColor = System.Drawing.Color.LightGreen;
            this.finishOrderButton.Location = new System.Drawing.Point(547, 513);
            this.finishOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(124, 55);
            this.finishOrderButton.TabIndex = 29;
            this.finishOrderButton.Text = "Finish";
            this.finishOrderButton.UseVisualStyleBackColor = false;
            // 
            // addCommentButton
            // 
            this.addCommentButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addCommentButton.Location = new System.Drawing.Point(374, 513);
            this.addCommentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(164, 55);
            this.addCommentButton.TabIndex = 28;
            this.addCommentButton.Text = "Comment";
            this.addCommentButton.UseVisualStyleBackColor = false;
            // 
            // decreaseOrderButton
            // 
            this.decreaseOrderButton.BackColor = System.Drawing.Color.LightSalmon;
            this.decreaseOrderButton.Location = new System.Drawing.Point(14, 513);
            this.decreaseOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decreaseOrderButton.Name = "decreaseOrderButton";
            this.decreaseOrderButton.Size = new System.Drawing.Size(117, 55);
            this.decreaseOrderButton.TabIndex = 27;
            this.decreaseOrderButton.Text = "Remove 1";
            this.decreaseOrderButton.UseVisualStyleBackColor = false;
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderColumnAaantal,
            this.OrderColumnName,
            this.OrderColumnPrice,
            this.OrderColumnType});
            this.orderListView.FullRowSelect = true;
            this.orderListView.Location = new System.Drawing.Point(11, 35);
            this.orderListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderListView.MultiSelect = false;
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(658, 467);
            this.orderListView.TabIndex = 26;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // OrderColumnAaantal
            // 
            this.OrderColumnAaantal.Text = "Aantal";
            this.OrderColumnAaantal.Width = 50;
            // 
            // OrderColumnName
            // 
            this.OrderColumnName.Text = "Naam";
            this.OrderColumnName.Width = 200;
            // 
            // OrderColumnPrice
            // 
            this.OrderColumnPrice.Text = "Prijs";
            this.OrderColumnPrice.Width = 80;
            // 
            // OrderColumnType
            // 
            this.OrderColumnType.Text = "Type";
            this.OrderColumnType.Width = 100;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(14, 15);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(147, 85);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 28;
            this.logoPictureBox.TabStop = false;
            // 
            // BtnBackServeerderUI
            // 
            this.BtnBackServeerderUI.Location = new System.Drawing.Point(541, 32);
            this.BtnBackServeerderUI.Name = "BtnBackServeerderUI";
            this.BtnBackServeerderUI.Size = new System.Drawing.Size(111, 36);
            this.BtnBackServeerderUI.TabIndex = 29;
            this.BtnBackServeerderUI.Text = "Back";
            this.BtnBackServeerderUI.UseVisualStyleBackColor = true;
            this.BtnBackServeerderUI.Click += new System.EventHandler(this.BtnBackServeerderUI_Click);
            // 
            // ServeerderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 1343);
            this.Controls.Add(this.BtnBackServeerderUI);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.orderGroupBox);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ServeerderUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServeerderUI";
            this.menuGroupBox.ResumeLayout(false);
            this.orderGroupBox.ResumeLayout(false);
            this.commentGroupBox.ResumeLayout(false);
            this.commentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button BtnBackServeerderUI;
    }
}