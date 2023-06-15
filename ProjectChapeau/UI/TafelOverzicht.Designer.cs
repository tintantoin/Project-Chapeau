namespace UI
{
    partial class TafelOverzicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TafelOverzicht));
            this.picChapeauLogIn = new System.Windows.Forms.PictureBox();
            this.btnTableFree = new System.Windows.Forms.Button();
            this.btnTableOccupied = new System.Windows.Forms.Button();
            this.btnTableReserved = new System.Windows.Forms.Button();
            this.btnTableOrdered = new System.Windows.Forms.Button();
            this.lblTableFree = new System.Windows.Forms.Label();
            this.lblTableOccupied = new System.Windows.Forms.Label();
            this.lblTableReserved = new System.Windows.Forms.Label();
            this.lblTableOrdered = new System.Windows.Forms.Label();
            this.tableLayoutPanelTafels = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picChapeauLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // picChapeauLogIn
            // 
            this.picChapeauLogIn.Image = ((System.Drawing.Image)(resources.GetObject("picChapeauLogIn.Image")));
            this.picChapeauLogIn.Location = new System.Drawing.Point(12, 12);
            this.picChapeauLogIn.Name = "picChapeauLogIn";
            this.picChapeauLogIn.Size = new System.Drawing.Size(179, 111);
            this.picChapeauLogIn.TabIndex = 1;
            this.picChapeauLogIn.TabStop = false;
            // 
            // btnTableFree
            // 
            this.btnTableFree.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnTableFree.Location = new System.Drawing.Point(93, 776);
            this.btnTableFree.Name = "btnTableFree";
            this.btnTableFree.Size = new System.Drawing.Size(44, 40);
            this.btnTableFree.TabIndex = 12;
            this.btnTableFree.UseVisualStyleBackColor = false;
            // 
            // btnTableOccupied
            // 
            this.btnTableOccupied.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTableOccupied.Location = new System.Drawing.Point(205, 776);
            this.btnTableOccupied.Name = "btnTableOccupied";
            this.btnTableOccupied.Size = new System.Drawing.Size(44, 40);
            this.btnTableOccupied.TabIndex = 13;
            this.btnTableOccupied.UseVisualStyleBackColor = false;
            // 
            // btnTableReserved
            // 
            this.btnTableReserved.BackColor = System.Drawing.Color.Silver;
            this.btnTableReserved.Location = new System.Drawing.Point(321, 776);
            this.btnTableReserved.Name = "btnTableReserved";
            this.btnTableReserved.Size = new System.Drawing.Size(44, 40);
            this.btnTableReserved.TabIndex = 14;
            this.btnTableReserved.UseVisualStyleBackColor = false;
            // 
            // btnTableOrdered
            // 
            this.btnTableOrdered.BackColor = System.Drawing.Color.Coral;
            this.btnTableOrdered.Location = new System.Drawing.Point(433, 776);
            this.btnTableOrdered.Name = "btnTableOrdered";
            this.btnTableOrdered.Size = new System.Drawing.Size(44, 40);
            this.btnTableOrdered.TabIndex = 15;
            this.btnTableOrdered.UseVisualStyleBackColor = false;
            // 
            // lblTableFree
            // 
            this.lblTableFree.AutoSize = true;
            this.lblTableFree.Location = new System.Drawing.Point(93, 834);
            this.lblTableFree.Name = "lblTableFree";
            this.lblTableFree.Size = new System.Drawing.Size(41, 20);
            this.lblTableFree.TabIndex = 16;
            this.lblTableFree.Text = "FREE";
            // 
            // lblTableOccupied
            // 
            this.lblTableOccupied.AutoSize = true;
            this.lblTableOccupied.Location = new System.Drawing.Point(188, 834);
            this.lblTableOccupied.Name = "lblTableOccupied";
            this.lblTableOccupied.Size = new System.Drawing.Size(79, 20);
            this.lblTableOccupied.TabIndex = 17;
            this.lblTableOccupied.Text = "OCCUPIED";
            // 
            // lblTableReserved
            // 
            this.lblTableReserved.AutoSize = true;
            this.lblTableReserved.Location = new System.Drawing.Point(307, 834);
            this.lblTableReserved.Name = "lblTableReserved";
            this.lblTableReserved.Size = new System.Drawing.Size(79, 20);
            this.lblTableReserved.TabIndex = 18;
            this.lblTableReserved.Text = "RESERVED";
            // 
            // lblTableOrdered
            // 
            this.lblTableOrdered.AutoSize = true;
            this.lblTableOrdered.Location = new System.Drawing.Point(417, 834);
            this.lblTableOrdered.Name = "lblTableOrdered";
            this.lblTableOrdered.Size = new System.Drawing.Size(76, 20);
            this.lblTableOrdered.TabIndex = 19;
            this.lblTableOrdered.Text = "ORDERED";
            // 
            // tableLayoutPanelTafels
            // 
            this.tableLayoutPanelTafels.ColumnCount = 2;
            this.tableLayoutPanelTafels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTafels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTafels.Location = new System.Drawing.Point(172, 209);
            this.tableLayoutPanelTafels.Name = "tableLayoutPanelTafels";
            this.tableLayoutPanelTafels.RowCount = 3;
            this.tableLayoutPanelTafels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.93939F));
            this.tableLayoutPanelTafels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.06061F));
            this.tableLayoutPanelTafels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanelTafels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanelTafels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTafels.Size = new System.Drawing.Size(250, 280);
            this.tableLayoutPanelTafels.TabIndex = 20;
            // 
            // TafelOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 890);
            this.Controls.Add(this.tableLayoutPanelTafels);
            this.Controls.Add(this.lblTableOrdered);
            this.Controls.Add(this.lblTableReserved);
            this.Controls.Add(this.lblTableOccupied);
            this.Controls.Add(this.lblTableFree);
            this.Controls.Add(this.btnTableOrdered);
            this.Controls.Add(this.btnTableReserved);
            this.Controls.Add(this.btnTableOccupied);
            this.Controls.Add(this.btnTableFree);
            this.Controls.Add(this.picChapeauLogIn);
            this.Name = "TafelOverzicht";
            this.Text = "TafelOverzicht";
            ((System.ComponentModel.ISupportInitialize)(this.picChapeauLogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picChapeauLogIn;
        private Button btnTableFree;
        private Button btnTableOccupied;
        private Button btnTableReserved;
        private Button btnTableOrdered;
        private Label lblTableFree;
        private Label lblTableOccupied;
        private Label lblTableReserved;
        private Label lblTableOrdered;
        private TableLayoutPanel tableLayoutPanelTafels;
    }
}