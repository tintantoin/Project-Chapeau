namespace ProjectChapeau.ChapeauUI
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
            TableLabel = new Label();
            tableNrLabel = new Label();
            radioButton1 = new RadioButton();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)picChapeauLogIn).BeginInit();
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
            // TableLabel
            // 
            TableLabel.AutoSize = true;
            TableLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TableLabel.Location = new Point(215, 49);
            TableLabel.Name = "TableLabel";
            TableLabel.Size = new Size(110, 46);
            TableLabel.TabIndex = 4;
            TableLabel.Text = "TABLE";
            TableLabel.Click += label1_Click;
            // 
            // tableNrLabel
            // 
            tableNrLabel.AutoSize = true;
            tableNrLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tableNrLabel.Location = new Point(320, 49);
            tableNrLabel.Name = "tableNrLabel";
            tableNrLabel.Size = new Size(0, 46);
            tableNrLabel.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 162);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(59, 244);
            listView1.Name = "listView1";
            listView1.Size = new Size(307, 365);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ServeerderUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 843);
            Controls.Add(listView1);
            Controls.Add(radioButton1);
            Controls.Add(tableNrLabel);
            Controls.Add(TableLabel);
            Controls.Add(picChapeauLogIn);
            Name = "ServeerderUI";
            Text = "ServeerderUI";
            ((System.ComponentModel.ISupportInitialize)picChapeauLogIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picChapeauLogIn;
        private Label TableLabel;
        private Label tableNrLabel;
        private RadioButton radioButton1;
        private ListView listView1;
    }
}