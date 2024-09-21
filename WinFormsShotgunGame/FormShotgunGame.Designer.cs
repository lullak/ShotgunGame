namespace WinFormsShotgunGame
{
    partial class FormShotgunGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShotgunGame));
            buttonShoot = new Button();
            buttonReload = new Button();
            buttonBlock = new Button();
            buttonShotgun = new Button();
            labelPlayerBullets = new Label();
            labelBotBullets = new Label();
            labelGameStatus = new Label();
            buttonGameRules = new Button();
            SuspendLayout();
            // 
            // buttonShoot
            // 
            buttonShoot.BackColor = Color.IndianRed;
            buttonShoot.FlatStyle = FlatStyle.Flat;
            buttonShoot.Font = new Font("Segoe UI", 14F);
            buttonShoot.ForeColor = SystemColors.ControlText;
            buttonShoot.Location = new Point(74, 56);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(116, 39);
            buttonShoot.TabIndex = 0;
            buttonShoot.Text = "Skjut";
            buttonShoot.UseVisualStyleBackColor = false;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonReload
            // 
            buttonReload.BackColor = Color.DarkGreen;
            buttonReload.FlatStyle = FlatStyle.Flat;
            buttonReload.Font = new Font("Segoe UI", 14F);
            buttonReload.Location = new Point(74, 117);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(116, 42);
            buttonReload.TabIndex = 1;
            buttonReload.Text = "Ladda";
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.BackColor = Color.Sienna;
            buttonBlock.FlatStyle = FlatStyle.Flat;
            buttonBlock.Font = new Font("Segoe UI", 14F);
            buttonBlock.Location = new Point(74, 176);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(116, 42);
            buttonBlock.TabIndex = 2;
            buttonBlock.Text = "Blocka";
            buttonBlock.UseVisualStyleBackColor = false;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonShotgun
            // 
            buttonShotgun.BackColor = Color.Gold;
            buttonShotgun.FlatStyle = FlatStyle.Flat;
            buttonShotgun.Font = new Font("Segoe UI", 14F);
            buttonShotgun.ForeColor = SystemColors.ControlText;
            buttonShotgun.Location = new Point(74, 241);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(116, 41);
            buttonShotgun.TabIndex = 3;
            buttonShotgun.Text = "Shotgun";
            buttonShotgun.UseVisualStyleBackColor = false;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // labelPlayerBullets
            // 
            labelPlayerBullets.AutoSize = true;
            labelPlayerBullets.BackColor = Color.Transparent;
            labelPlayerBullets.FlatStyle = FlatStyle.Flat;
            labelPlayerBullets.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayerBullets.ForeColor = Color.FromArgb(255, 192, 255);
            labelPlayerBullets.Location = new Point(260, 56);
            labelPlayerBullets.Name = "labelPlayerBullets";
            labelPlayerBullets.Size = new Size(198, 29);
            labelPlayerBullets.TabIndex = 4;
            labelPlayerBullets.Text = "Player Bullets";
            // 
            // labelBotBullets
            // 
            labelBotBullets.AutoSize = true;
            labelBotBullets.BackColor = Color.Transparent;
            labelBotBullets.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBotBullets.ForeColor = Color.FromArgb(255, 192, 255);
            labelBotBullets.Location = new Point(604, 56);
            labelBotBullets.Name = "labelBotBullets";
            labelBotBullets.Size = new Size(158, 29);
            labelBotBullets.TabIndex = 5;
            labelBotBullets.Text = "Bot Bullets";
            // 
            // labelGameStatus
            // 
            labelGameStatus.AutoSize = true;
            labelGameStatus.BackColor = Color.Transparent;
            labelGameStatus.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGameStatus.ForeColor = Color.Black;
            labelGameStatus.Location = new Point(354, 176);
            labelGameStatus.Name = "labelGameStatus";
            labelGameStatus.Size = new Size(273, 37);
            labelGameStatus.TabIndex = 6;
            labelGameStatus.Text = "Välj ditt drag.";
            // 
            // buttonGameRules
            // 
            buttonGameRules.Location = new Point(932, 463);
            buttonGameRules.Name = "buttonGameRules";
            buttonGameRules.Size = new Size(94, 29);
            buttonGameRules.TabIndex = 7;
            buttonGameRules.Text = "Spelregler";
            buttonGameRules.UseVisualStyleBackColor = true;
            buttonGameRules.Click += buttonGameRules_Click;
            // 
            // FormShotgunGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1026, 492);
            Controls.Add(buttonGameRules);
            Controls.Add(labelGameStatus);
            Controls.Add(labelBotBullets);
            Controls.Add(labelPlayerBullets);
            Controls.Add(buttonShotgun);
            Controls.Add(buttonBlock);
            Controls.Add(buttonReload);
            Controls.Add(buttonShoot);
            Name = "FormShotgunGame";
            Text = "Shotgun Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShoot;
        private Button buttonReload;
        private Button buttonBlock;
        private Button buttonShotgun;
        private Label labelPlayerBullets;
        private Label labelBotBullets;
        private Label labelGameStatus;
        private Button buttonGameRules;
    }
}
