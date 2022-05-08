namespace oofgates.main
{
    partial class Ibattle
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
            this.EventPanel = new System.Windows.Forms.Panel();
            this.BattleEventTextbox = new System.Windows.Forms.TextBox();
            this.BattleAbilityPanel = new System.Windows.Forms.Panel();
            this.AbilityButton4 = new System.Windows.Forms.Button();
            this.AbilityButton3 = new System.Windows.Forms.Button();
            this.AbilityButton2 = new System.Windows.Forms.Button();
            this.AbilityButton1 = new System.Windows.Forms.Button();
            this.UserBattleInfo = new System.Windows.Forms.Panel();
            this.UserLevelLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserTotalEnergyBar = new System.Windows.Forms.Panel();
            this.UserCurrEnergyBar = new System.Windows.Forms.Panel();
            this.UserTotalHealthBar = new System.Windows.Forms.Panel();
            this.UserCurrHealthBar = new System.Windows.Forms.Panel();
            this.EnemyBattleInfo = new System.Windows.Forms.Panel();
            this.EnemyLevelLabel = new System.Windows.Forms.Label();
            this.EnemyNameLabel = new System.Windows.Forms.Label();
            this.EnemyTotalEnergyBar = new System.Windows.Forms.Panel();
            this.EnemyCurrEnergyBar = new System.Windows.Forms.Panel();
            this.EnemyTotHealthBar = new System.Windows.Forms.Panel();
            this.EnemyCurrHealthBar = new System.Windows.Forms.Panel();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.FacePanel = new System.Windows.Forms.Panel();
            this.RunButton = new System.Windows.Forms.Button();
            this.UseItemButton = new System.Windows.Forms.Button();
            this.FightButton = new System.Windows.Forms.Button();
            this.EnemyImage = new System.Windows.Forms.PictureBox();
            this.EventPanel.SuspendLayout();
            this.BattleAbilityPanel.SuspendLayout();
            this.UserBattleInfo.SuspendLayout();
            this.UserTotalEnergyBar.SuspendLayout();
            this.UserTotalHealthBar.SuspendLayout();
            this.EnemyBattleInfo.SuspendLayout();
            this.EnemyTotalEnergyBar.SuspendLayout();
            this.EnemyTotHealthBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.FacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EventPanel
            // 
            this.EventPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventPanel.Controls.Add(this.BattleEventTextbox);
            this.EventPanel.Location = new System.Drawing.Point(0, 290);
            this.EventPanel.Name = "EventPanel";
            this.EventPanel.Size = new System.Drawing.Size(482, 169);
            this.EventPanel.TabIndex = 10;
            // 
            // BattleEventTextbox
            // 
            this.BattleEventTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BattleEventTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BattleEventTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleEventTextbox.Location = new System.Drawing.Point(-1, 25);
            this.BattleEventTextbox.Multiline = true;
            this.BattleEventTextbox.Name = "BattleEventTextbox";
            this.BattleEventTextbox.ReadOnly = true;
            this.BattleEventTextbox.Size = new System.Drawing.Size(482, 127);
            this.BattleEventTextbox.TabIndex = 0;
            this.BattleEventTextbox.Text = "battle event text here";
            // 
            // BattleAbilityPanel
            // 
            this.BattleAbilityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BattleAbilityPanel.Controls.Add(this.AbilityButton4);
            this.BattleAbilityPanel.Controls.Add(this.AbilityButton3);
            this.BattleAbilityPanel.Controls.Add(this.AbilityButton2);
            this.BattleAbilityPanel.Controls.Add(this.AbilityButton1);
            this.BattleAbilityPanel.Location = new System.Drawing.Point(258, 290);
            this.BattleAbilityPanel.Name = "BattleAbilityPanel";
            this.BattleAbilityPanel.Size = new System.Drawing.Size(224, 169);
            this.BattleAbilityPanel.TabIndex = 4;
            this.BattleAbilityPanel.Visible = false;
            this.BattleAbilityPanel.MouseLeave += new System.EventHandler(this.BattleAbilityPanel_MouseLeave);
            // 
            // AbilityButton4
            // 
            this.AbilityButton4.Location = new System.Drawing.Point(116, 98);
            this.AbilityButton4.Name = "AbilityButton4";
            this.AbilityButton4.Size = new System.Drawing.Size(100, 50);
            this.AbilityButton4.TabIndex = 3;
            this.AbilityButton4.Text = "ability4";
            this.AbilityButton4.UseVisualStyleBackColor = true;
            this.AbilityButton4.Click += new System.EventHandler(this.AbilityButton4_Click);
            this.AbilityButton4.MouseHover += new System.EventHandler(this.AbilityButton4_MouseHover);
            // 
            // AbilityButton3
            // 
            this.AbilityButton3.Location = new System.Drawing.Point(10, 98);
            this.AbilityButton3.Name = "AbilityButton3";
            this.AbilityButton3.Size = new System.Drawing.Size(100, 50);
            this.AbilityButton3.TabIndex = 2;
            this.AbilityButton3.Text = "ability3";
            this.AbilityButton3.UseVisualStyleBackColor = true;
            this.AbilityButton3.Click += new System.EventHandler(this.AbilityButton3_Click);
            this.AbilityButton3.MouseHover += new System.EventHandler(this.AbilityButton3_MouseHover);
            // 
            // AbilityButton2
            // 
            this.AbilityButton2.Location = new System.Drawing.Point(116, 18);
            this.AbilityButton2.Name = "AbilityButton2";
            this.AbilityButton2.Size = new System.Drawing.Size(100, 50);
            this.AbilityButton2.TabIndex = 1;
            this.AbilityButton2.Text = "ability2";
            this.AbilityButton2.UseVisualStyleBackColor = true;
            this.AbilityButton2.Click += new System.EventHandler(this.AbilityButton2_Click);
            this.AbilityButton2.MouseHover += new System.EventHandler(this.AbilityButton2_MouseHover);
            // 
            // AbilityButton1
            // 
            this.AbilityButton1.Location = new System.Drawing.Point(10, 18);
            this.AbilityButton1.Name = "AbilityButton1";
            this.AbilityButton1.Size = new System.Drawing.Size(100, 50);
            this.AbilityButton1.TabIndex = 0;
            this.AbilityButton1.Text = "ability1";
            this.AbilityButton1.UseVisualStyleBackColor = true;
            this.AbilityButton1.Click += new System.EventHandler(this.AbilityButton1_Click);
            this.AbilityButton1.MouseHover += new System.EventHandler(this.AbilityButton1_MouseHover);
            // 
            // UserBattleInfo
            // 
            this.UserBattleInfo.BackColor = System.Drawing.Color.RosyBrown;
            this.UserBattleInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserBattleInfo.Controls.Add(this.UserLevelLabel);
            this.UserBattleInfo.Controls.Add(this.UserNameLabel);
            this.UserBattleInfo.Controls.Add(this.UserTotalEnergyBar);
            this.UserBattleInfo.Controls.Add(this.UserTotalHealthBar);
            this.UserBattleInfo.Location = new System.Drawing.Point(217, 155);
            this.UserBattleInfo.Name = "UserBattleInfo";
            this.UserBattleInfo.Size = new System.Drawing.Size(244, 70);
            this.UserBattleInfo.TabIndex = 9;
            // 
            // UserLevelLabel
            // 
            this.UserLevelLabel.AutoSize = true;
            this.UserLevelLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLevelLabel.Location = new System.Drawing.Point(167, 8);
            this.UserLevelLabel.Name = "UserLevelLabel";
            this.UserLevelLabel.Size = new System.Drawing.Size(30, 23);
            this.UserLevelLabel.TabIndex = 5;
            this.UserLevelLabel.Text = "Lv";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(0, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(135, 32);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "user name";
            // 
            // UserTotalEnergyBar
            // 
            this.UserTotalEnergyBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserTotalEnergyBar.Controls.Add(this.UserCurrEnergyBar);
            this.UserTotalEnergyBar.Location = new System.Drawing.Point(41, 49);
            this.UserTotalEnergyBar.Name = "UserTotalEnergyBar";
            this.UserTotalEnergyBar.Size = new System.Drawing.Size(184, 7);
            this.UserTotalEnergyBar.TabIndex = 4;
            // 
            // UserCurrEnergyBar
            // 
            this.UserCurrEnergyBar.BackColor = System.Drawing.Color.Gold;
            this.UserCurrEnergyBar.Location = new System.Drawing.Point(0, 0);
            this.UserCurrEnergyBar.Name = "UserCurrEnergyBar";
            this.UserCurrEnergyBar.Size = new System.Drawing.Size(184, 7);
            this.UserCurrEnergyBar.TabIndex = 0;
            // 
            // UserTotalHealthBar
            // 
            this.UserTotalHealthBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserTotalHealthBar.Controls.Add(this.UserCurrHealthBar);
            this.UserTotalHealthBar.Location = new System.Drawing.Point(41, 35);
            this.UserTotalHealthBar.Name = "UserTotalHealthBar";
            this.UserTotalHealthBar.Size = new System.Drawing.Size(184, 14);
            this.UserTotalHealthBar.TabIndex = 1;
            // 
            // UserCurrHealthBar
            // 
            this.UserCurrHealthBar.BackColor = System.Drawing.Color.SpringGreen;
            this.UserCurrHealthBar.Location = new System.Drawing.Point(0, 0);
            this.UserCurrHealthBar.Name = "UserCurrHealthBar";
            this.UserCurrHealthBar.Size = new System.Drawing.Size(184, 14);
            this.UserCurrHealthBar.TabIndex = 0;
            // 
            // EnemyBattleInfo
            // 
            this.EnemyBattleInfo.BackColor = System.Drawing.Color.RosyBrown;
            this.EnemyBattleInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemyBattleInfo.Controls.Add(this.EnemyLevelLabel);
            this.EnemyBattleInfo.Controls.Add(this.EnemyNameLabel);
            this.EnemyBattleInfo.Controls.Add(this.EnemyTotalEnergyBar);
            this.EnemyBattleInfo.Controls.Add(this.EnemyTotHealthBar);
            this.EnemyBattleInfo.Location = new System.Drawing.Point(33, 14);
            this.EnemyBattleInfo.Name = "EnemyBattleInfo";
            this.EnemyBattleInfo.Size = new System.Drawing.Size(244, 70);
            this.EnemyBattleInfo.TabIndex = 8;
            // 
            // EnemyLevelLabel
            // 
            this.EnemyLevelLabel.AutoSize = true;
            this.EnemyLevelLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyLevelLabel.Location = new System.Drawing.Point(167, 8);
            this.EnemyLevelLabel.Name = "EnemyLevelLabel";
            this.EnemyLevelLabel.Size = new System.Drawing.Size(30, 23);
            this.EnemyLevelLabel.TabIndex = 5;
            this.EnemyLevelLabel.Text = "Lv";
            // 
            // EnemyNameLabel
            // 
            this.EnemyNameLabel.AutoSize = true;
            this.EnemyNameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyNameLabel.Location = new System.Drawing.Point(0, 0);
            this.EnemyNameLabel.Name = "EnemyNameLabel";
            this.EnemyNameLabel.Size = new System.Drawing.Size(161, 32);
            this.EnemyNameLabel.TabIndex = 2;
            this.EnemyNameLabel.Text = "enemy name";
            // 
            // EnemyTotalEnergyBar
            // 
            this.EnemyTotalEnergyBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnemyTotalEnergyBar.Controls.Add(this.EnemyCurrEnergyBar);
            this.EnemyTotalEnergyBar.Location = new System.Drawing.Point(41, 49);
            this.EnemyTotalEnergyBar.Name = "EnemyTotalEnergyBar";
            this.EnemyTotalEnergyBar.Size = new System.Drawing.Size(184, 7);
            this.EnemyTotalEnergyBar.TabIndex = 4;
            // 
            // EnemyCurrEnergyBar
            // 
            this.EnemyCurrEnergyBar.BackColor = System.Drawing.Color.Gold;
            this.EnemyCurrEnergyBar.Location = new System.Drawing.Point(0, 0);
            this.EnemyCurrEnergyBar.Name = "EnemyCurrEnergyBar";
            this.EnemyCurrEnergyBar.Size = new System.Drawing.Size(184, 7);
            this.EnemyCurrEnergyBar.TabIndex = 0;
            // 
            // EnemyTotHealthBar
            // 
            this.EnemyTotHealthBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnemyTotHealthBar.Controls.Add(this.EnemyCurrHealthBar);
            this.EnemyTotHealthBar.Location = new System.Drawing.Point(41, 35);
            this.EnemyTotHealthBar.Name = "EnemyTotHealthBar";
            this.EnemyTotHealthBar.Size = new System.Drawing.Size(184, 14);
            this.EnemyTotHealthBar.TabIndex = 1;
            // 
            // EnemyCurrHealthBar
            // 
            this.EnemyCurrHealthBar.BackColor = System.Drawing.Color.SpringGreen;
            this.EnemyCurrHealthBar.Location = new System.Drawing.Point(0, 0);
            this.EnemyCurrHealthBar.Name = "EnemyCurrHealthBar";
            this.EnemyCurrHealthBar.Size = new System.Drawing.Size(184, 14);
            this.EnemyCurrHealthBar.TabIndex = 0;
            // 
            // UserImage
            // 
            this.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserImage.Location = new System.Drawing.Point(40, 130);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(145, 145);
            this.UserImage.TabIndex = 5;
            this.UserImage.TabStop = false;
            // 
            // FacePanel
            // 
            this.FacePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacePanel.Controls.Add(this.RunButton);
            this.FacePanel.Controls.Add(this.UseItemButton);
            this.FacePanel.Controls.Add(this.FightButton);
            this.FacePanel.Location = new System.Drawing.Point(0, 290);
            this.FacePanel.Name = "FacePanel";
            this.FacePanel.Size = new System.Drawing.Size(482, 169);
            this.FacePanel.TabIndex = 3;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(244, 18);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(105, 130);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // UseItemButton
            // 
            this.UseItemButton.Location = new System.Drawing.Point(133, 18);
            this.UseItemButton.Name = "UseItemButton";
            this.UseItemButton.Size = new System.Drawing.Size(105, 130);
            this.UseItemButton.TabIndex = 1;
            this.UseItemButton.Text = "Use Item";
            this.UseItemButton.UseVisualStyleBackColor = true;
            // 
            // FightButton
            // 
            this.FightButton.Location = new System.Drawing.Point(22, 18);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(105, 130);
            this.FightButton.TabIndex = 0;
            this.FightButton.Text = "Fight";
            this.FightButton.UseVisualStyleBackColor = true;
            // 
            // EnemyImage
            // 
            this.EnemyImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EnemyImage.Location = new System.Drawing.Point(330, 4);
            this.EnemyImage.Name = "EnemyImage";
            this.EnemyImage.Size = new System.Drawing.Size(145, 145);
            this.EnemyImage.TabIndex = 0;
            this.EnemyImage.TabStop = false;
            // 
            // Ibattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BattleAbilityPanel);
            this.Controls.Add(this.FacePanel);
            this.Controls.Add(this.UserImage);
            this.Controls.Add(this.EnemyImage);
            this.Controls.Add(this.EnemyBattleInfo);
            this.Controls.Add(this.UserBattleInfo);
            this.Controls.Add(this.EventPanel);
            this.Name = "Ibattle";
            this.Size = new System.Drawing.Size(482, 459);
            this.EventPanel.ResumeLayout(false);
            this.EventPanel.PerformLayout();
            this.BattleAbilityPanel.ResumeLayout(false);
            this.UserBattleInfo.ResumeLayout(false);
            this.UserBattleInfo.PerformLayout();
            this.UserTotalEnergyBar.ResumeLayout(false);
            this.UserTotalHealthBar.ResumeLayout(false);
            this.EnemyBattleInfo.ResumeLayout(false);
            this.EnemyBattleInfo.PerformLayout();
            this.EnemyTotalEnergyBar.ResumeLayout(false);
            this.EnemyTotHealthBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.FacePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel EventPanel;
        private System.Windows.Forms.TextBox BattleEventTextbox;
        private System.Windows.Forms.Panel BattleAbilityPanel;
        private System.Windows.Forms.Button AbilityButton4;
        private System.Windows.Forms.Button AbilityButton3;
        private System.Windows.Forms.Button AbilityButton2;
        private System.Windows.Forms.Button AbilityButton1;
        private System.Windows.Forms.Panel UserBattleInfo;
        private System.Windows.Forms.Label UserLevelLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel UserTotalEnergyBar;
        private System.Windows.Forms.Panel UserCurrEnergyBar;
        private System.Windows.Forms.Panel UserTotalHealthBar;
        private System.Windows.Forms.Panel UserCurrHealthBar;
        private System.Windows.Forms.Panel EnemyBattleInfo;
        private System.Windows.Forms.Label EnemyLevelLabel;
        private System.Windows.Forms.Label EnemyNameLabel;
        private System.Windows.Forms.Panel EnemyTotalEnergyBar;
        private System.Windows.Forms.Panel EnemyCurrEnergyBar;
        private System.Windows.Forms.Panel EnemyTotHealthBar;
        private System.Windows.Forms.Panel EnemyCurrHealthBar;
        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.Panel FacePanel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button UseItemButton;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.PictureBox EnemyImage;
    }
}
