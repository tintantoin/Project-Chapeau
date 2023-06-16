
namespace UI
{
    partial class TafelStatusUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TafelStatusUI));
            this.picChapeauLogIn = new System.Windows.Forms.PictureBox();
            this.lblTheTable = new System.Windows.Forms.Label();
            this.btnStatusFree = new System.Windows.Forms.Button();
            this.btnStatusOccupied = new System.Windows.Forms.Button();
            this.btnStatusReserved = new System.Windows.Forms.Button();
            this.btnBackTafelStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChapeauLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // picChapeauLogIn
            // 
            this.picChapeauLogIn.Image = ((System.Drawing.Image)(resources.GetObject("picChapeauLogIn.Image")));
            this.picChapeauLogIn.Location = new System.Drawing.Point(12, 12);
            this.picChapeauLogIn.Name = "picChapeauLogIn";
            this.picChapeauLogIn.Size = new System.Drawing.Size(179, 111);
            this.picChapeauLogIn.TabIndex = 2;
            this.picChapeauLogIn.TabStop = false;
            // 
            // lblTheTable
            // 
            this.lblTheTable.AutoSize = true;
            this.lblTheTable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTheTable.Location = new System.Drawing.Point(225, 199);
            this.lblTheTable.Name = "lblTheTable";
            this.lblTheTable.Size = new System.Drawing.Size(87, 41);
            this.lblTheTable.TabIndex = 3;
            this.lblTheTable.Text = "Table";
            // 
            // btnStatusFree
            // 
            this.btnStatusFree.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnStatusFree.Location = new System.Drawing.Point(58, 386);
            this.btnStatusFree.Name = "btnStatusFree";
            this.btnStatusFree.Size = new System.Drawing.Size(115, 44);
            this.btnStatusFree.TabIndex = 4;
            this.btnStatusFree.Text = "FREE";
            this.btnStatusFree.UseVisualStyleBackColor = false;
            this.btnStatusFree.Click += new System.EventHandler(this.btnStatusFree_Click);
            // 
            // btnStatusOccupied
            // 
            this.btnStatusOccupied.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStatusOccupied.Location = new System.Drawing.Point(208, 386);
            this.btnStatusOccupied.Name = "btnStatusOccupied";
            this.btnStatusOccupied.Size = new System.Drawing.Size(115, 44);
            this.btnStatusOccupied.TabIndex = 5;
            this.btnStatusOccupied.Text = "OCCUPIED";
            this.btnStatusOccupied.UseVisualStyleBackColor = false;
            this.btnStatusOccupied.Click += new System.EventHandler(this.btnStatusOccupied_Click);
            // 
            // btnStatusReserved
            // 
            this.btnStatusReserved.BackColor = System.Drawing.Color.Silver;
            this.btnStatusReserved.Location = new System.Drawing.Point(371, 386);
            this.btnStatusReserved.Name = "btnStatusReserved";
            this.btnStatusReserved.Size = new System.Drawing.Size(115, 44);
            this.btnStatusReserved.TabIndex = 6;
            this.btnStatusReserved.Text = "RESERVED";
            this.btnStatusReserved.UseVisualStyleBackColor = false;
            this.btnStatusReserved.Click += new System.EventHandler(this.btnStatusReserved_Click);
            // 
            // btnBackTafelStatus
            // 
            this.btnBackTafelStatus.Location = new System.Drawing.Point(75, 621);
            this.btnBackTafelStatus.Name = "btnBackTafelStatus";
            this.btnBackTafelStatus.Size = new System.Drawing.Size(116, 42);
            this.btnBackTafelStatus.TabIndex = 7;
            this.btnBackTafelStatus.Text = "Back";
            this.btnBackTafelStatus.UseVisualStyleBackColor = true;
            this.btnBackTafelStatus.Click += new System.EventHandler(this.btnBackTafelStatus_Click);
            // 
            // TafelStatusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 843);
            this.Controls.Add(this.btnBackTafelStatus);
            this.Controls.Add(this.btnStatusReserved);
            this.Controls.Add(this.btnStatusOccupied);
            this.Controls.Add(this.btnStatusFree);
            this.Controls.Add(this.lblTheTable);
            this.Controls.Add(this.picChapeauLogIn);
            this.Name = "TafelStatusUI";
            this.Text = "TafelStatusUI";
            ((System.ComponentModel.ISupportInitialize)(this.picChapeauLogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picChapeauLogIn;
        private Label lblTheTable;
        private Button btnStatusFree;
        private Button btnStatusOccupied;
        private Button btnStatusReserved;
        private Button btnBackTafelStatus;
    }
}