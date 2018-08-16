namespace Russian_Roulette
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
            this.BtnLoadBullet = new System.Windows.Forms.Button();
            this.BtnSpinChambers = new System.Windows.Forms.Button();
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.RBtnPointAtHead = new System.Windows.Forms.RadioButton();
            this.RbtnPointAway = new System.Windows.Forms.RadioButton();
            this.BtnFire = new System.Windows.Forms.Button();
            this.PbGun = new System.Windows.Forms.PictureBox();
            this.PbDog = new System.Windows.Forms.PictureBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDog)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadBullet
            // 
            this.BtnLoadBullet.BackColor = System.Drawing.Color.IndianRed;
            this.BtnLoadBullet.Location = new System.Drawing.Point(417, 121);
            this.BtnLoadBullet.Name = "BtnLoadBullet";
            this.BtnLoadBullet.Size = new System.Drawing.Size(150, 31);
            this.BtnLoadBullet.TabIndex = 0;
            this.BtnLoadBullet.Text = "Load Bullet";
            this.BtnLoadBullet.UseVisualStyleBackColor = false;
            this.BtnLoadBullet.Click += new System.EventHandler(this.BtnLoadBullet_Click);
            // 
            // BtnSpinChambers
            // 
            this.BtnSpinChambers.BackColor = System.Drawing.Color.IndianRed;
            this.BtnSpinChambers.Location = new System.Drawing.Point(417, 158);
            this.BtnSpinChambers.Name = "BtnSpinChambers";
            this.BtnSpinChambers.Size = new System.Drawing.Size(150, 30);
            this.BtnSpinChambers.TabIndex = 1;
            this.BtnSpinChambers.Text = "Spin Chambers";
            this.BtnSpinChambers.UseVisualStyleBackColor = false;
            this.BtnSpinChambers.Click += new System.EventHandler(this.BtnSpinChambers_Click);
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.BackColor = System.Drawing.Color.IndianRed;
            this.BtnPlayAgain.Location = new System.Drawing.Point(417, 194);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(150, 30);
            this.BtnPlayAgain.TabIndex = 2;
            this.BtnPlayAgain.Text = " Play Again";
            this.BtnPlayAgain.UseVisualStyleBackColor = false;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // RBtnPointAtHead
            // 
            this.RBtnPointAtHead.AutoSize = true;
            this.RBtnPointAtHead.BackColor = System.Drawing.Color.RosyBrown;
            this.RBtnPointAtHead.Location = new System.Drawing.Point(440, 23);
            this.RBtnPointAtHead.Name = "RBtnPointAtHead";
            this.RBtnPointAtHead.Size = new System.Drawing.Size(116, 21);
            this.RBtnPointAtHead.TabIndex = 4;
            this.RBtnPointAtHead.TabStop = true;
            this.RBtnPointAtHead.Text = "Point At Head";
            this.RBtnPointAtHead.UseVisualStyleBackColor = false;
            // 
            // RbtnPointAway
            // 
            this.RbtnPointAway.AutoSize = true;
            this.RbtnPointAway.BackColor = System.Drawing.Color.RosyBrown;
            this.RbtnPointAway.Location = new System.Drawing.Point(440, 50);
            this.RbtnPointAway.Name = "RbtnPointAway";
            this.RbtnPointAway.Size = new System.Drawing.Size(98, 21);
            this.RbtnPointAway.TabIndex = 5;
            this.RbtnPointAway.TabStop = true;
            this.RbtnPointAway.Text = "Point Away";
            this.RbtnPointAway.UseVisualStyleBackColor = false;
            this.RbtnPointAway.CheckedChanged += new System.EventHandler(this.RbtnPointAway_CheckedChanged);
            // 
            // BtnFire
            // 
            this.BtnFire.BackColor = System.Drawing.Color.IndianRed;
            this.BtnFire.Location = new System.Drawing.Point(12, 346);
            this.BtnFire.Name = "BtnFire";
            this.BtnFire.Size = new System.Drawing.Size(536, 43);
            this.BtnFire.TabIndex = 6;
            this.BtnFire.Text = "  Fire";
            this.BtnFire.UseVisualStyleBackColor = false;
            this.BtnFire.Click += new System.EventHandler(this.BtnFire_Click);
            // 
            // PbGun
            // 
            this.PbGun.Image = global::Russian_Roulette.Resource1.gun;
            this.PbGun.Location = new System.Drawing.Point(28, 12);
            this.PbGun.Name = "PbGun";
            this.PbGun.Size = new System.Drawing.Size(162, 150);
            this.PbGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbGun.TabIndex = 8;
            this.PbGun.TabStop = false;
            // 
            // PbDog
            // 
            this.PbDog.Image = global::Russian_Roulette.Resource1.dog;
            this.PbDog.Location = new System.Drawing.Point(196, 12);
            this.PbDog.Name = "PbDog";
            this.PbDog.Size = new System.Drawing.Size(196, 186);
            this.PbDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbDog.TabIndex = 7;
            this.PbDog.TabStop = false;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 16;
            this.lbxOutput.Location = new System.Drawing.Point(196, 256);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(120, 84);
            this.lbxOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.PbGun);
            this.Controls.Add(this.PbDog);
            this.Controls.Add(this.BtnFire);
            this.Controls.Add(this.RbtnPointAway);
            this.Controls.Add(this.RBtnPointAtHead);
            this.Controls.Add(this.BtnPlayAgain);
            this.Controls.Add(this.BtnSpinChambers);
            this.Controls.Add(this.BtnLoadBullet);
            this.Name = "Form1";
            this.Text = "Shot Fired";
            ((System.ComponentModel.ISupportInitialize)(this.PbGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadBullet;
        private System.Windows.Forms.Button BtnSpinChambers;
        private System.Windows.Forms.Button BtnPlayAgain;
        private System.Windows.Forms.RadioButton RBtnPointAtHead;
        private System.Windows.Forms.RadioButton RbtnPointAway;
        private System.Windows.Forms.Button BtnFire;
        private System.Windows.Forms.PictureBox PbDog;
        private System.Windows.Forms.PictureBox PbGun;
        private System.Windows.Forms.ListBox lbxOutput;
    }
}

