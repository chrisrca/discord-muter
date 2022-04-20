namespace Mald_Muter
{
    partial class splashScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.enableBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.disableBtn = new System.Windows.Forms.Button();
            this.dashBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Mald_Muter.Properties.Resources.UnMuted;
            this.pictureBox1.Location = new System.Drawing.Point(100, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.background.Location = new System.Drawing.Point(1, 28);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(297, 321);
            this.background.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Mald_Muter.Properties.Resources.Muted;
            this.pictureBox2.Location = new System.Drawing.Point(100, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // enableBtn
            // 
            this.enableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.enableBtn.FlatAppearance.BorderSize = 0;
            this.enableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableBtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enableBtn.ForeColor = System.Drawing.Color.White;
            this.enableBtn.Location = new System.Drawing.Point(67, 214);
            this.enableBtn.Name = "enableBtn";
            this.enableBtn.Size = new System.Drawing.Size(165, 59);
            this.enableBtn.TabIndex = 3;
            this.enableBtn.Text = "Enable";
            this.enableBtn.UseVisualStyleBackColor = false;
            this.enableBtn.Click += new System.EventHandler(this.enableBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(2, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 53);
            this.label1.TabIndex = 4;
            // 
            // disableBtn
            // 
            this.disableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.disableBtn.FlatAppearance.BorderSize = 0;
            this.disableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableBtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disableBtn.ForeColor = System.Drawing.Color.White;
            this.disableBtn.Location = new System.Drawing.Point(67, 214);
            this.disableBtn.Name = "disableBtn";
            this.disableBtn.Size = new System.Drawing.Size(165, 59);
            this.disableBtn.TabIndex = 5;
            this.disableBtn.Text = "Disable";
            this.disableBtn.UseVisualStyleBackColor = false;
            this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.dashBtn.FlatAppearance.BorderSize = 0;
            this.dashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBtn.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashBtn.ForeColor = System.Drawing.Color.White;
            this.dashBtn.Location = new System.Drawing.Point(1, 296);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(150, 53);
            this.dashBtn.TabIndex = 6;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.UseVisualStyleBackColor = false;
            this.dashBtn.DragLeave += new System.EventHandler(this.dashBtn_DragLeave);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(149, 296);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(150, 53);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.DragLeave += new System.EventHandler(this.settingsBtn_DragLeave);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.dashBtn);
            this.Controls.Add(this.enableBtn);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label background;
        private PictureBox pictureBox2;
        private Button enableBtn;
        private Label label1;
        private Button disableBtn;
        private Button dashBtn;
        private Button settingsBtn;
    }
}