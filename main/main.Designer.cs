namespace oofgates
{
    partial class Main
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
            this.ibattle1 = new oofgates.main.Ibattle();
            this.iuserinfo1 = new oofgates.main.Iuserinfo();
            this.istats1 = new oofgates.main.Istats();
            this.imain1 = new oofgates.main.Imain();
            this.SuspendLayout();
            // 
            // ibattle1
            // 
            this.ibattle1.Location = new System.Drawing.Point(0, 0);
            this.ibattle1.Name = "ibattle1";
            this.ibattle1.Size = new System.Drawing.Size(482, 459);
            this.ibattle1.TabIndex = 2;
            // 
            // iuserinfo1
            // 
            this.iuserinfo1.Location = new System.Drawing.Point(0, 0);
            this.iuserinfo1.Name = "iuserinfo1";
            this.iuserinfo1.Size = new System.Drawing.Size(406, 298);
            this.iuserinfo1.TabIndex = 1;
            // 
            // istats1
            // 
            this.istats1.Location = new System.Drawing.Point(12, 12);
            this.istats1.Name = "istats1";
            this.istats1.Size = new System.Drawing.Size(142, 151);
            this.istats1.TabIndex = 0;
            // 
            // imain1
            // 
            this.imain1.Location = new System.Drawing.Point(0, 0);
            this.imain1.Name = "imain1";
            this.imain1.Size = new System.Drawing.Size(487, 439);
            this.imain1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.imain1);
            this.Controls.Add(this.ibattle1);
            this.Controls.Add(this.iuserinfo1);
            this.Controls.Add(this.istats1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Main";
            this.Text = "OofGates";
            this.ResumeLayout(false);

        }

        #endregion

        private main.Istats istats1;
        private main.Iuserinfo iuserinfo1;
        private main.Ibattle ibattle1;
        private main.Imain imain1;
    }
}

