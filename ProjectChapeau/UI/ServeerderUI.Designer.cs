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
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            MenuListview = new ListView();
            NameHeader = new ColumnHeader();
            priceHeader = new ColumnHeader();
            label7 = new Label();
            MenuTypeHeader = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)picChapeauLogIn).BeginInit();
            SuspendLayout();
            // 
            // picChapeauLogIn
            // 
            picChapeauLogIn.Image = (Image)resources.GetObject("picChapeauLogIn.Image");
            picChapeauLogIn.Location = new Point(12, 12);
            picChapeauLogIn.Name = "picChapeauLogIn";
            picChapeauLogIn.Size = new Size(179, 111);
            picChapeauLogIn.TabIndex = 2;
            picChapeauLogIn.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(228, 47);
            label1.Name = "label1";
            label1.Size = new Size(97, 46);
            label1.TabIndex = 3;
            label1.Text = "Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(321, 47);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(42, 178);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "LUNCH";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(228, 178);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "DINNER";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(417, 178);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 24);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "DRINKS";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // MenuListview
            // 
            MenuListview.Columns.AddRange(new ColumnHeader[] { NameHeader, priceHeader, MenuTypeHeader });
            MenuListview.GridLines = true;
            MenuListview.Location = new Point(69, 259);
            MenuListview.Name = "MenuListview";
            MenuListview.Size = new Size(448, 157);
            MenuListview.TabIndex = 8;
            MenuListview.UseCompatibleStateImageBehavior = false;
            MenuListview.View = View.Details;
            MenuListview.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // NameHeader
            // 
            NameHeader.Text = "Name";
            NameHeader.Width = 200;
            // 
            // priceHeader
            // 
            priceHeader.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(206, 221);
            label7.Name = "label7";
            label7.Size = new Size(0, 35);
            label7.TabIndex = 14;
            // 
            // MenuTypeHeader
            // 
            MenuTypeHeader.Text = "Menutype";
            MenuTypeHeader.Width = 200;
            // 
            // ServeerderUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 910);
            Controls.Add(label7);
            Controls.Add(MenuListview);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picChapeauLogIn);
            Name = "ServeerderUI";
            Text = "ServeerderUI";
            ((System.ComponentModel.ISupportInitialize)picChapeauLogIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picChapeauLogIn;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ListView MenuListview;
        private ColumnHeader NameHeader;
        private ColumnHeader priceHeader;
        private Label label7;
        private ColumnHeader MenuTypeHeader;
    }
}