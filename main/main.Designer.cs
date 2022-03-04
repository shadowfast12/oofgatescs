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
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.event_text = new System.Windows.Forms.TextBox();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.option4 = new System.Windows.Forms.Button();
            this.stats_button = new System.Windows.Forms.Button();
            this.events_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(13, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(168, 42);
            this.title.TabIndex = 0;
            this.title.Text = "OofGates";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.Location = new System.Drawing.Point(17, 55);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(138, 15);
            this.subtitle.TabIndex = 1;
            this.subtitle.Text = "A BAUMAN CREATION\r\n";
            this.subtitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // event_text
            // 
            this.event_text.BackColor = System.Drawing.Color.Silver;
            this.event_text.Enabled = false;
            this.event_text.Location = new System.Drawing.Point(12, 97);
            this.event_text.Multiline = true;
            this.event_text.Name = "event_text";
            this.event_text.ReadOnly = true;
            this.event_text.Size = new System.Drawing.Size(486, 151);
            this.event_text.TabIndex = 2;
            this.event_text.Text = "text here";
            this.event_text.TextChanged += new System.EventHandler(this.event_text_TextChanged);
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(12, 254);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(169, 50);
            this.option1.TabIndex = 3;
            this.option1.Text = "option 1";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(12, 310);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(169, 50);
            this.option2.TabIndex = 4;
            this.option2.Text = "option2";
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(12, 366);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(169, 50);
            this.option3.TabIndex = 5;
            this.option3.Text = "option3";
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option4
            // 
            this.option4.Location = new System.Drawing.Point(12, 422);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(169, 50);
            this.option4.TabIndex = 6;
            this.option4.Text = "option4";
            this.option4.UseVisualStyleBackColor = true;
            // 
            // stats_button
            // 
            this.stats_button.Location = new System.Drawing.Point(381, 345);
            this.stats_button.Name = "stats_button";
            this.stats_button.Size = new System.Drawing.Size(117, 50);
            this.stats_button.TabIndex = 7;
            this.stats_button.Text = "Stats";
            this.stats_button.UseVisualStyleBackColor = true;
            // 
            // events_button
            // 
            this.events_button.Location = new System.Drawing.Point(381, 401);
            this.events_button.Name = "events_button";
            this.events_button.Size = new System.Drawing.Size(117, 50);
            this.events_button.TabIndex = 8;
            this.events_button.Text = "Events";
            this.events_button.UseVisualStyleBackColor = true;
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(381, 457);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(117, 22);
            this.settings_button.TabIndex = 9;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(510, 485);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.events_button);
            this.Controls.Add(this.stats_button);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.event_text);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "main";
            this.Text = "OofGates";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.TextBox event_text;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Button option4;
        private System.Windows.Forms.Button stats_button;
        private System.Windows.Forms.Button events_button;
        private System.Windows.Forms.Button settings_button;
    }
}

