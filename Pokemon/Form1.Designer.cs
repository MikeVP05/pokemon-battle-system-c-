namespace Pokemon
{
    partial class Form1
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
            this.attackMenu = new System.Windows.Forms.Button();
            this.itemsMenu = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.switchMenu = new System.Windows.Forms.Button();
            this.friendlyHp = new System.Windows.Forms.ProgressBar();
            this.enemyHp = new System.Windows.Forms.ProgressBar();
            this.friendlyName = new System.Windows.Forms.Label();
            this.enemyName = new System.Windows.Forms.Label();
            this.enemyPicture = new System.Windows.Forms.PictureBox();
            this.friendlyPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fightPanel = new System.Windows.Forms.Panel();
            this.attack4 = new System.Windows.Forms.Button();
            this.attack3 = new System.Windows.Forms.Button();
            this.attack2 = new System.Windows.Forms.Button();
            this.attack1 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.friendlyHpLabel = new System.Windows.Forms.Label();
            this.enemyHpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.fightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // attackMenu
            // 
            this.attackMenu.Location = new System.Drawing.Point(3, 3);
            this.attackMenu.Name = "attackMenu";
            this.attackMenu.Size = new System.Drawing.Size(130, 54);
            this.attackMenu.TabIndex = 0;
            this.attackMenu.Text = "Fight";
            this.attackMenu.UseVisualStyleBackColor = true;
            this.attackMenu.Click += new System.EventHandler(this.attackMenu_Click);
            // 
            // itemsMenu
            // 
            this.itemsMenu.Location = new System.Drawing.Point(139, 3);
            this.itemsMenu.Name = "itemsMenu";
            this.itemsMenu.Size = new System.Drawing.Size(128, 54);
            this.itemsMenu.TabIndex = 1;
            this.itemsMenu.Text = "Items";
            this.itemsMenu.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(139, 63);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(128, 54);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // switchMenu
            // 
            this.switchMenu.Location = new System.Drawing.Point(3, 63);
            this.switchMenu.Name = "switchMenu";
            this.switchMenu.Size = new System.Drawing.Size(130, 54);
            this.switchMenu.TabIndex = 2;
            this.switchMenu.Text = "Switch";
            this.switchMenu.UseVisualStyleBackColor = true;
            // 
            // friendlyHp
            // 
            this.friendlyHp.Location = new System.Drawing.Point(12, 126);
            this.friendlyHp.Name = "friendlyHp";
            this.friendlyHp.Size = new System.Drawing.Size(229, 23);
            this.friendlyHp.TabIndex = 4;
            // 
            // enemyHp
            // 
            this.enemyHp.Location = new System.Drawing.Point(679, 32);
            this.enemyHp.Name = "enemyHp";
            this.enemyHp.Size = new System.Drawing.Size(229, 23);
            this.enemyHp.TabIndex = 5;
            // 
            // friendlyName
            // 
            this.friendlyName.AutoSize = true;
            this.friendlyName.Location = new System.Drawing.Point(13, 107);
            this.friendlyName.Name = "friendlyName";
            this.friendlyName.Size = new System.Drawing.Size(68, 13);
            this.friendlyName.TabIndex = 6;
            this.friendlyName.Text = "friendlyName";
            // 
            // enemyName
            // 
            this.enemyName.AutoSize = true;
            this.enemyName.Location = new System.Drawing.Point(839, 9);
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(66, 13);
            this.enemyName.TabIndex = 7;
            this.enemyName.Text = "enemyName";
            // 
            // enemyPicture
            // 
            this.enemyPicture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.enemyPicture.InitialImage = null;
            this.enemyPicture.Location = new System.Drawing.Point(708, 62);
            this.enemyPicture.Name = "enemyPicture";
            this.enemyPicture.Size = new System.Drawing.Size(200, 135);
            this.enemyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPicture.TabIndex = 8;
            this.enemyPicture.TabStop = false;
            this.enemyPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // friendlyPicture
            // 
            this.friendlyPicture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.friendlyPicture.Location = new System.Drawing.Point(12, 155);
            this.friendlyPicture.Name = "friendlyPicture";
            this.friendlyPicture.Size = new System.Drawing.Size(200, 135);
            this.friendlyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendlyPicture.TabIndex = 9;
            this.friendlyPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.attackMenu);
            this.panel1.Controls.Add(this.itemsMenu);
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Controls.Add(this.switchMenu);
            this.panel1.Location = new System.Drawing.Point(637, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 124);
            this.panel1.TabIndex = 10;
            // 
            // fightPanel
            // 
            this.fightPanel.Controls.Add(this.attack1);
            this.fightPanel.Controls.Add(this.attack2);
            this.fightPanel.Controls.Add(this.attack3);
            this.fightPanel.Controls.Add(this.attack4);
            this.fightPanel.Location = new System.Drawing.Point(12, 323);
            this.fightPanel.Name = "fightPanel";
            this.fightPanel.Size = new System.Drawing.Size(550, 124);
            this.fightPanel.TabIndex = 11;
            this.fightPanel.Visible = false;
            // 
            // attack4
            // 
            this.attack4.Location = new System.Drawing.Point(414, 3);
            this.attack4.Name = "attack4";
            this.attack4.Size = new System.Drawing.Size(130, 118);
            this.attack4.TabIndex = 1;
            this.attack4.Text = "Fight";
            this.attack4.UseVisualStyleBackColor = true;
            // 
            // attack3
            // 
            this.attack3.Location = new System.Drawing.Point(278, 3);
            this.attack3.Name = "attack3";
            this.attack3.Size = new System.Drawing.Size(130, 118);
            this.attack3.TabIndex = 2;
            this.attack3.Text = "Fight";
            this.attack3.UseVisualStyleBackColor = true;
            // 
            // attack2
            // 
            this.attack2.Location = new System.Drawing.Point(142, 3);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(130, 118);
            this.attack2.TabIndex = 3;
            this.attack2.Text = "Fight";
            this.attack2.UseVisualStyleBackColor = true;
            // 
            // attack1
            // 
            this.attack1.Location = new System.Drawing.Point(6, 3);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(130, 118);
            this.attack1.TabIndex = 4;
            this.attack1.Text = "Fight";
            this.attack1.UseVisualStyleBackColor = true;
            this.attack1.Click += new System.EventHandler(this.attack1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(406, 182);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 54);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // friendlyHpLabel
            // 
            this.friendlyHpLabel.AutoSize = true;
            this.friendlyHpLabel.Location = new System.Drawing.Point(87, 107);
            this.friendlyHpLabel.Name = "friendlyHpLabel";
            this.friendlyHpLabel.Size = new System.Drawing.Size(24, 13);
            this.friendlyHpLabel.TabIndex = 12;
            this.friendlyHpLabel.Text = "0/0";
            // 
            // enemyHpLabel
            // 
            this.enemyHpLabel.AutoSize = true;
            this.enemyHpLabel.Location = new System.Drawing.Point(787, 9);
            this.enemyHpLabel.Name = "enemyHpLabel";
            this.enemyHpLabel.Size = new System.Drawing.Size(24, 13);
            this.enemyHpLabel.TabIndex = 13;
            this.enemyHpLabel.Text = "0/0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 459);
            this.Controls.Add(this.enemyHpLabel);
            this.Controls.Add(this.friendlyHpLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.fightPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.friendlyPicture);
            this.Controls.Add(this.enemyPicture);
            this.Controls.Add(this.enemyName);
            this.Controls.Add(this.friendlyName);
            this.Controls.Add(this.enemyHp);
            this.Controls.Add(this.friendlyHp);
            this.Name = "Form1";
            this.Text = "Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.fightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attackMenu;
        private System.Windows.Forms.Button itemsMenu;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button switchMenu;
        private System.Windows.Forms.ProgressBar friendlyHp;
        private System.Windows.Forms.ProgressBar enemyHp;
        private System.Windows.Forms.Label friendlyName;
        private System.Windows.Forms.Label enemyName;
        private System.Windows.Forms.PictureBox enemyPicture;
        private System.Windows.Forms.PictureBox friendlyPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel fightPanel;
        private System.Windows.Forms.Button attack1;
        private System.Windows.Forms.Button attack2;
        private System.Windows.Forms.Button attack3;
        private System.Windows.Forms.Button attack4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label friendlyHpLabel;
        private System.Windows.Forms.Label enemyHpLabel;
    }
}

