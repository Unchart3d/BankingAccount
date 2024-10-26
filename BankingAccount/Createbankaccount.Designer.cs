namespace BankingAccount
{
    partial class Createbankaccount
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.accountname = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Account name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Account Number";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Initial Balance";
            // 
            // accountname
            // 
            this.accountname.Location = new System.Drawing.Point(137, 41);
            this.accountname.Name = "accountname";
            this.accountname.Size = new System.Drawing.Size(263, 20);
            this.accountname.TabIndex = 4;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(137, 77);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(263, 20);
            this.number.TabIndex = 5;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(137, 119);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(263, 20);
            this.balance.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 77);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createaccount);
            // 
            // Createbankaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.number);
            this.Controls.Add(this.accountname);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Createbankaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox accountname;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button button1;
    }
}

