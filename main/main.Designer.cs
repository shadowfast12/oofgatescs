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
            this.settings_button = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.stats_text_box = new System.Windows.Forms.TextBox();
            this.inventory_info = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.battle_panel = new System.Windows.Forms.Panel();
            this.total_energy_bar = new System.Windows.Forms.Panel();
            this.curr_energy_bar = new System.Windows.Forms.Panel();
            this.face_pan = new System.Windows.Forms.Panel();
            this.f_button3 = new System.Windows.Forms.Button();
            this.f_button2 = new System.Windows.Forms.Button();
            this.f_button1 = new System.Windows.Forms.Button();
            this.enemy_name_label = new System.Windows.Forms.Label();
            this.enemy_tothealth_bar = new System.Windows.Forms.Panel();
            this.enemy_healthbar = new System.Windows.Forms.Panel();
            this.enemy_image = new System.Windows.Forms.PictureBox();
            this.item_overview_panel = new System.Windows.Forms.Panel();
            this.item_overview_textbox = new System.Windows.Forms.TextBox();
            this.main_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.battle_panel.SuspendLayout();
            this.total_energy_bar.SuspendLayout();
            this.face_pan.SuspendLayout();
            this.enemy_tothealth_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_image)).BeginInit();
            this.item_overview_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(168, 42);
            this.title.TabIndex = 0;
            this.title.Text = "OofGates";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.Location = new System.Drawing.Point(22, 42);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(138, 15);
            this.subtitle.TabIndex = 1;
            this.subtitle.Text = "A BAUMAN CREATION\r\n";
            // 
            // event_text
            // 
            this.event_text.BackColor = System.Drawing.Color.Silver;
            this.event_text.Enabled = false;
            this.event_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_text.Location = new System.Drawing.Point(0, 60);
            this.event_text.Multiline = true;
            this.event_text.Name = "event_text";
            this.event_text.ReadOnly = true;
            this.event_text.Size = new System.Drawing.Size(487, 151);
            this.event_text.TabIndex = 2;
            this.event_text.Text = "text here";
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(3, 217);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(169, 50);
            this.option1.TabIndex = 3;
            this.option1.Text = "option 1";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            this.option1.MouseLeave += new System.EventHandler(this.option1_MouseLeave);
            this.option1.MouseHover += new System.EventHandler(this.option1_MouseHover);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(3, 273);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(169, 50);
            this.option2.TabIndex = 4;
            this.option2.Text = "option2";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(3, 328);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(169, 50);
            this.option3.TabIndex = 5;
            this.option3.Text = "option3";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // option4
            // 
            this.option4.Location = new System.Drawing.Point(3, 384);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(169, 50);
            this.option4.TabIndex = 6;
            this.option4.Text = "option4";
            this.option4.UseVisualStyleBackColor = true;
            this.option4.Click += new System.EventHandler(this.option4_Click);
            // 
            // stats_button
            // 
            this.stats_button.Location = new System.Drawing.Point(367, 362);
            this.stats_button.Name = "stats_button";
            this.stats_button.Size = new System.Drawing.Size(117, 50);
            this.stats_button.TabIndex = 7;
            this.stats_button.Text = "Stats";
            this.stats_button.UseVisualStyleBackColor = true;
            this.stats_button.Click += new System.EventHandler(this.stats_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(367, 418);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(117, 28);
            this.settings_button.TabIndex = 9;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.subtitle);
            this.main_panel.Controls.Add(this.settings_button);
            this.main_panel.Controls.Add(this.title);
            this.main_panel.Controls.Add(this.event_text);
            this.main_panel.Controls.Add(this.stats_button);
            this.main_panel.Controls.Add(this.option1);
            this.main_panel.Controls.Add(this.option4);
            this.main_panel.Controls.Add(this.option2);
            this.main_panel.Controls.Add(this.option3);
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(487, 459);
            this.main_panel.TabIndex = 10;
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.stats_text_box);
            this.info_panel.Controls.Add(this.inventory_info);
            this.info_panel.Controls.Add(this.label1);
            this.info_panel.Controls.Add(this.back_button);
            this.info_panel.Enabled = false;
            this.info_panel.Location = new System.Drawing.Point(37, 58);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(406, 298);
            this.info_panel.TabIndex = 11;
            this.info_panel.Visible = false;
            // 
            // stats_text_box
            // 
            this.stats_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_text_box.Location = new System.Drawing.Point(14, 81);
            this.stats_text_box.Multiline = true;
            this.stats_text_box.Name = "stats_text_box";
            this.stats_text_box.ReadOnly = true;
            this.stats_text_box.Size = new System.Drawing.Size(167, 183);
            this.stats_text_box.TabIndex = 12;
            // 
            // inventory_info
            // 
            this.inventory_info.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_info.Location = new System.Drawing.Point(234, 52);
            this.inventory_info.Multiline = true;
            this.inventory_info.Name = "inventory_info";
            this.inventory_info.ReadOnly = true;
            this.inventory_info.Size = new System.Drawing.Size(167, 183);
            this.inventory_info.TabIndex = 11;
            this.inventory_info.Text = "Inventory Items\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 5;
            this.label1.Tag = "";
            this.label1.Text = "Player Info";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(3, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(73, 33);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // battle_panel
            // 
            this.battle_panel.Controls.Add(this.total_energy_bar);
            this.battle_panel.Controls.Add(this.face_pan);
            this.battle_panel.Controls.Add(this.enemy_name_label);
            this.battle_panel.Controls.Add(this.enemy_tothealth_bar);
            this.battle_panel.Controls.Add(this.enemy_image);
            this.battle_panel.Enabled = false;
            this.battle_panel.Location = new System.Drawing.Point(601, 110);
            this.battle_panel.Name = "battle_panel";
            this.battle_panel.Size = new System.Drawing.Size(487, 459);
            this.battle_panel.TabIndex = 11;
            this.battle_panel.Visible = false;
            // 
            // total_energy_bar
            // 
            this.total_energy_bar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.total_energy_bar.Controls.Add(this.curr_energy_bar);
            this.total_energy_bar.Location = new System.Drawing.Point(66, 83);
            this.total_energy_bar.Name = "total_energy_bar";
            this.total_energy_bar.Size = new System.Drawing.Size(247, 7);
            this.total_energy_bar.TabIndex = 4;
            // 
            // curr_energy_bar
            // 
            this.curr_energy_bar.BackColor = System.Drawing.Color.Gold;
            this.curr_energy_bar.Location = new System.Drawing.Point(0, 0);
            this.curr_energy_bar.Name = "curr_energy_bar";
            this.curr_energy_bar.Size = new System.Drawing.Size(247, 7);
            this.curr_energy_bar.TabIndex = 0;
            // 
            // face_pan
            // 
            this.face_pan.Controls.Add(this.f_button3);
            this.face_pan.Controls.Add(this.f_button2);
            this.face_pan.Controls.Add(this.f_button1);
            this.face_pan.Location = new System.Drawing.Point(0, 290);
            this.face_pan.Name = "face_pan";
            this.face_pan.Size = new System.Drawing.Size(487, 169);
            this.face_pan.TabIndex = 3;
            // 
            // f_button3
            // 
            this.f_button3.Location = new System.Drawing.Point(342, 18);
            this.f_button3.Name = "f_button3";
            this.f_button3.Size = new System.Drawing.Size(124, 130);
            this.f_button3.TabIndex = 2;
            this.f_button3.Text = "Run";
            this.f_button3.UseVisualStyleBackColor = true;
            this.f_button3.Click += new System.EventHandler(this.f_button3_Click);
            // 
            // f_button2
            // 
            this.f_button2.Location = new System.Drawing.Point(183, 18);
            this.f_button2.Name = "f_button2";
            this.f_button2.Size = new System.Drawing.Size(124, 130);
            this.f_button2.TabIndex = 1;
            this.f_button2.Text = "Use Item";
            this.f_button2.UseVisualStyleBackColor = true;
            this.f_button2.Click += new System.EventHandler(this.f_button2_Click);
            // 
            // f_button1
            // 
            this.f_button1.Location = new System.Drawing.Point(22, 18);
            this.f_button1.Name = "f_button1";
            this.f_button1.Size = new System.Drawing.Size(124, 130);
            this.f_button1.TabIndex = 0;
            this.f_button1.Text = "Fight";
            this.f_button1.UseVisualStyleBackColor = true;
            this.f_button1.Click += new System.EventHandler(this.f_button1_Click);
            // 
            // enemy_name_label
            // 
            this.enemy_name_label.AutoSize = true;
            this.enemy_name_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_name_label.Location = new System.Drawing.Point(66, 12);
            this.enemy_name_label.Name = "enemy_name_label";
            this.enemy_name_label.Size = new System.Drawing.Size(161, 32);
            this.enemy_name_label.TabIndex = 2;
            this.enemy_name_label.Text = "enemy name";
            this.enemy_name_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // enemy_tothealth_bar
            // 
            this.enemy_tothealth_bar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enemy_tothealth_bar.Controls.Add(this.enemy_healthbar);
            this.enemy_tothealth_bar.Location = new System.Drawing.Point(66, 69);
            this.enemy_tothealth_bar.Name = "enemy_tothealth_bar";
            this.enemy_tothealth_bar.Size = new System.Drawing.Size(247, 14);
            this.enemy_tothealth_bar.TabIndex = 1;
            // 
            // enemy_healthbar
            // 
            this.enemy_healthbar.BackColor = System.Drawing.Color.SpringGreen;
            this.enemy_healthbar.Location = new System.Drawing.Point(0, 0);
            this.enemy_healthbar.Name = "enemy_healthbar";
            this.enemy_healthbar.Size = new System.Drawing.Size(247, 14);
            this.enemy_healthbar.TabIndex = 0;
            // 
            // enemy_image
            // 
            this.enemy_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enemy_image.Location = new System.Drawing.Point(321, 12);
            this.enemy_image.Name = "enemy_image";
            this.enemy_image.Size = new System.Drawing.Size(145, 145);
            this.enemy_image.TabIndex = 0;
            this.enemy_image.TabStop = false;
            // 
            // item_overview_panel
            // 
            this.item_overview_panel.Controls.Add(this.item_overview_textbox);
            this.item_overview_panel.Location = new System.Drawing.Point(519, 43);
            this.item_overview_panel.Name = "item_overview_panel";
            this.item_overview_panel.Size = new System.Drawing.Size(142, 150);
            this.item_overview_panel.TabIndex = 5;
            // 
            // item_overview_textbox
            // 
            this.item_overview_textbox.Location = new System.Drawing.Point(0, -1);
            this.item_overview_textbox.Multiline = true;
            this.item_overview_textbox.Name = "item_overview_textbox";
            this.item_overview_textbox.ReadOnly = true;
            this.item_overview_textbox.Size = new System.Drawing.Size(142, 151);
            this.item_overview_textbox.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1133, 595);
            this.Controls.Add(this.item_overview_panel);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.battle_panel);
            this.Controls.Add(this.main_panel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Main";
            this.Text = "OofGates";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.battle_panel.ResumeLayout(false);
            this.battle_panel.PerformLayout();
            this.total_energy_bar.ResumeLayout(false);
            this.face_pan.ResumeLayout(false);
            this.enemy_tothealth_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemy_image)).EndInit();
            this.item_overview_panel.ResumeLayout(false);
            this.item_overview_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Button stats_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.TextBox event_text;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Button option4;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.TextBox inventory_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel battle_panel;
        private System.Windows.Forms.PictureBox enemy_image;
        private System.Windows.Forms.Panel enemy_tothealth_bar;
        private System.Windows.Forms.Panel enemy_healthbar;
        private System.Windows.Forms.Label enemy_name_label;
        private System.Windows.Forms.Panel face_pan;
        private System.Windows.Forms.Button f_button1;
        private System.Windows.Forms.Panel total_energy_bar;
        private System.Windows.Forms.Panel curr_energy_bar;
        private System.Windows.Forms.Button f_button2;
        private System.Windows.Forms.Button f_button3;
        private System.Windows.Forms.Panel item_overview_panel;
        private System.Windows.Forms.TextBox item_overview_textbox;
        private System.Windows.Forms.TextBox stats_text_box;
    }
}

