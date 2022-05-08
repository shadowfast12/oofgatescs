namespace oofgates.main
{
    partial class Istats
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
            this.OverviewTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OverviewTextbox
            // 
            this.OverviewTextbox.Enabled = false;
            this.OverviewTextbox.Location = new System.Drawing.Point(0, 0);
            this.OverviewTextbox.Multiline = true;
            this.OverviewTextbox.Name = "OverviewTextbox";
            this.OverviewTextbox.ReadOnly = true;
            this.OverviewTextbox.Size = new System.Drawing.Size(142, 151);
            this.OverviewTextbox.TabIndex = 1;
            // 
            // Istats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OverviewTextbox);
            this.Name = "Istats";
            this.Size = new System.Drawing.Size(142, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OverviewTextbox;
    }
}
