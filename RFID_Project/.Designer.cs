namespace RFID_Project
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.BTNvalidate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BTNvalidate);
            this.panel1.Controls.Add(this.NewPassword);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(57, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 242);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 123);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(89, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Login :";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(175, 91);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(90, 20);
            this.Login.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(175, 126);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(90, 20);
            this.Password.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Location = new System.Drawing.Point(89, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Password :";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(175, 162);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(90, 20);
            this.NewPassword.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox6.Location = new System.Drawing.Point(89, 162);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "New Password :";
            // 
            // BTNvalidate
            // 
            this.BTNvalidate.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTNvalidate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvalidate.ForeColor = System.Drawing.Color.White;
            this.BTNvalidate.Location = new System.Drawing.Point(132, 198);
            this.BTNvalidate.Name = "BTNvalidate";
            this.BTNvalidate.Size = new System.Drawing.Size(83, 26);
            this.BTNvalidate.TabIndex = 7;
            this.BTNvalidate.Text = "VALIDATE";
            this.BTNvalidate.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(476, 343);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNvalidate;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}
