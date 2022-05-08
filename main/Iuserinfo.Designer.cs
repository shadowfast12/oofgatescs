namespace oofgates.main
{
    partial class Iuserinfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatsTextbox = new System.Windows.Forms.TextBox();
            this.InventoryInfoTextbox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatsTextbox
            // 
            this.StatsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsTextbox.Location = new System.Drawing.Point(22, 76);
            this.StatsTextbox.Multiline = true;
            this.StatsTextbox.Name = "StatsTextbox";
            this.StatsTextbox.ReadOnly = true;
            this.StatsTextbox.Size = new System.Drawing.Size(167, 183);
            this.StatsTextbox.TabIndex = 12;
            // 
            // InventoryInfoTextbox
            // 
            this.InventoryInfoTextbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryInfoTextbox.Location = new System.Drawing.Point(219, 76);
            this.InventoryInfoTextbox.Multiline = true;
            this.InventoryInfoTextbox.Name = "InventoryInfoTextbox";
            this.InventoryInfoTextbox.ReadOnly = true;
            this.InventoryInfoTextbox.Size = new System.Drawing.Size(167, 183);
            this.InventoryInfoTextbox.TabIndex = 11;
            this.InventoryInfoTextbox.Text = "Inventory Items\r\n";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(15, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(174, 37);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Tag = "";
            this.TitleLabel.Text = "Player Info";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(73, 33);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // Iuserinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatsTextbox);
            this.Controls.Add(this.InventoryInfoTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BackButton);
            this.Name = "Iuserinfo";
            this.Size = new System.Drawing.Size(406, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StatsTextbox;
        private System.Windows.Forms.TextBox InventoryInfoTextbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button BackButton;
    }
}
