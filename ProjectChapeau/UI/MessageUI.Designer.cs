namespace UI
{
    partial class MessageUI
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
            button1 = new Button();
            OpmerkingBox = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 75);
            button1.Name = "button1";
            button1.Size = new Size(141, 58);
            button1.TabIndex = 0;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            // 
            // OpmerkingBox
            // 
            OpmerkingBox.Location = new Point(168, 236);
            OpmerkingBox.Name = "OpmerkingBox";
            OpmerkingBox.Size = new Size(304, 171);
            OpmerkingBox.TabIndex = 2;
            OpmerkingBox.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(208, 427);
            button2.Name = "button2";
            button2.Size = new Size(211, 53);
            button2.TabIndex = 3;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            // 
            // MessageUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 827);
            Controls.Add(button2);
            Controls.Add(OpmerkingBox);
            Controls.Add(button1);
            Name = "MessageUI";
            Text = "MessageUI";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox OpmerkingBox;
        private Button button2;
    }
}