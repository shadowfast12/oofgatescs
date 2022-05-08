namespace oofgates.main
{
    partial class Imain
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
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EventTextbox = new System.Windows.Forms.TextBox();
            this.StatsButton = new System.Windows.Forms.Button();
            this.Option1Button = new System.Windows.Forms.Button();
            this.Option4Button = new System.Windows.Forms.Button();
            this.Option2Button = new System.Windows.Forms.Button();
            this.Option3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(22, 42);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(138, 15);
            this.SubtitleLabel.TabIndex = 11;
            this.SubtitleLabel.Text = "A BAUMAN CREATION\r\n";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(359, 403);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(117, 28);
            this.SettingsButton.TabIndex = 18;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(168, 42);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "OofGates";
            // 
            // EventTextbox
            // 
            this.EventTextbox.BackColor = System.Drawing.Color.Silver;
            this.EventTextbox.Enabled = false;
            this.EventTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTextbox.Location = new System.Drawing.Point(10, 60);
            this.EventTextbox.Multiline = true;
            this.EventTextbox.Name = "EventTextbox";
            this.EventTextbox.ReadOnly = true;
            this.EventTextbox.Size = new System.Drawing.Size(466, 151);
            this.EventTextbox.TabIndex = 12;
            this.EventTextbox.Text = "text here";
            // 
            // StatsButton
            // 
            this.StatsButton.Location = new System.Drawing.Point(359, 347);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(117, 50);
            this.StatsButton.TabIndex = 17;
            this.StatsButton.Text = "Stats";
            this.StatsButton.UseVisualStyleBackColor = true;
            this.StatsButton.Click += new System.EventHandler(this.stats_button_Click);
            // 
            // Option1Button
            // 
            this.Option1Button.Location = new System.Drawing.Point(10, 217);
            this.Option1Button.Name = "Option1Button";
            this.Option1Button.Size = new System.Drawing.Size(260, 50);
            this.Option1Button.TabIndex = 13;
            this.Option1Button.Text = "option 1";
            this.Option1Button.UseVisualStyleBackColor = true;
            this.Option1Button.Click += new System.EventHandler(this.option1_button_Click);
            this.Option1Button.MouseHover += new System.EventHandler(this.Option1Button_MouseHover);
            // 
            // Option4Button
            // 
            this.Option4Button.Location = new System.Drawing.Point(10, 384);
            this.Option4Button.Name = "Option4Button";
            this.Option4Button.Size = new System.Drawing.Size(260, 50);
            this.Option4Button.TabIndex = 16;
            this.Option4Button.Text = "option4";
            this.Option4Button.UseVisualStyleBackColor = true;
            this.Option4Button.Click += new System.EventHandler(this.option4_button_Click);
            // 
            // Option2Button
            // 
            this.Option2Button.Location = new System.Drawing.Point(10, 273);
            this.Option2Button.Name = "Option2Button";
            this.Option2Button.Size = new System.Drawing.Size(260, 50);
            this.Option2Button.TabIndex = 14;
            this.Option2Button.Text = "option2";
            this.Option2Button.UseVisualStyleBackColor = true;
            this.Option2Button.Click += new System.EventHandler(this.option2_button_Click);
            this.Option2Button.MouseHover += new System.EventHandler(this.Option2Button_MouseHover);
            // 
            // Option3Button
            // 
            this.Option3Button.Location = new System.Drawing.Point(10, 329);
            this.Option3Button.Name = "Option3Button";
            this.Option3Button.Size = new System.Drawing.Size(260, 50);
            this.Option3Button.TabIndex = 15;
            this.Option3Button.Text = "option3";
            this.Option3Button.UseVisualStyleBackColor = true;
            this.Option3Button.Click += new System.EventHandler(this.option3_button_Click);
            this.Option3Button.MouseHover += new System.EventHandler(this.Option3Button_MouseHover);
            // 
            // Ifacemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EventTextbox);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.Option1Button);
            this.Controls.Add(this.Option4Button);
            this.Controls.Add(this.Option2Button);
            this.Controls.Add(this.Option3Button);
            this.Name = "Ifacemain";
            this.Size = new System.Drawing.Size(487, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox EventTextbox;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.Button Option1Button;
        private System.Windows.Forms.Button Option4Button;
        private System.Windows.Forms.Button Option2Button;
        private System.Windows.Forms.Button Option3Button;
    }
}
