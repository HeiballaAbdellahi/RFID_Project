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
            this.btnvalidate = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.credit = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.debit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.debit);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.credit);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.balance);
            this.panel1.Controls.Add(this.btnvalidate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 258);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 137);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnvalidate
            // 
            this.btnvalidate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnvalidate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnvalidate.FlatAppearance.BorderSize = 0;
            this.btnvalidate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnvalidate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnvalidate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidate.Location = new System.Drawing.Point(223, 213);
            this.btnvalidate.Name = "btnvalidate";
            this.btnvalidate.Size = new System.Drawing.Size(80, 32);
            this.btnvalidate.TabIndex = 3;
            this.btnvalidate.Text = "VALIDATE";
            this.btnvalidate.UseVisualStyleBackColor = false;
            this.btnvalidate.Click += new System.EventHandler(this.button1_Click);
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(243, 109);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(106, 20);
            this.balance.TabIndex = 4;
            this.balance.Enter += new System.EventHandler(this.txtUserEnter);
            this.balance.Leave += new System.EventHandler(this.txtUserLeave);
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Location = new System.Drawing.Point(173, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Balance :";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(173, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Credit :";
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(243, 144);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(106, 20);
            this.credit.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.Location = new System.Drawing.Point(173, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(64, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Debit :";
            // 
            // debit
            // 
            this.debit.Location = new System.Drawing.Point(243, 178);
            this.debit.Name = "debit";
            this.debit.Size = new System.Drawing.Size(106, 20);
            this.debit.TabIndex = 8;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(624, 354);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnvalidate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox debit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox balance;
    }
}
