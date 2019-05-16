namespace WindowsFormsApp1
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
            this.btnGetToken = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtTokenUrl = new System.Windows.Forms.TextBox();
            this.txtTokenKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtTokenSifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtGetAskerUrl = new System.Windows.Forms.TextBox();
            this.btnGetAsker = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAsker = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(9, 67);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(76, 23);
            this.btnGetToken.TabIndex = 0;
            this.btnGetToken.Text = "Get Token";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(91, 69);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(716, 20);
            this.txtToken.TabIndex = 1;
            // 
            // txtTokenUrl
            // 
            this.txtTokenUrl.Location = new System.Drawing.Point(91, 43);
            this.txtTokenUrl.Name = "txtTokenUrl";
            this.txtTokenUrl.Size = new System.Drawing.Size(269, 20);
            this.txtTokenUrl.TabIndex = 2;
            this.txtTokenUrl.Text = "http://localhost:51563/token";
            // 
            // txtTokenKullaniciAdi
            // 
            this.txtTokenKullaniciAdi.Location = new System.Drawing.Point(366, 43);
            this.txtTokenKullaniciAdi.Name = "txtTokenKullaniciAdi";
            this.txtTokenKullaniciAdi.Size = new System.Drawing.Size(121, 20);
            this.txtTokenKullaniciAdi.TabIndex = 3;
            this.txtTokenKullaniciAdi.Text = "kkkk";
            // 
            // txtTokenSifre
            // 
            this.txtTokenSifre.Location = new System.Drawing.Point(493, 43);
            this.txtTokenSifre.Name = "txtTokenSifre";
            this.txtTokenSifre.PasswordChar = '*';
            this.txtTokenSifre.Size = new System.Drawing.Size(100, 20);
            this.txtTokenSifre.TabIndex = 4;
            this.txtTokenSifre.Text = "123456";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtExpire);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtToken);
            this.groupBox1.Controls.Add(this.txtTokenSifre);
            this.groupBox1.Controls.Add(this.btnGetToken);
            this.groupBox1.Controls.Add(this.txtTokenKullaniciAdi);
            this.groupBox1.Controls.Add(this.txtTokenUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "KullanıcıAdı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // txtExpire
            // 
            this.txtExpire.Location = new System.Drawing.Point(814, 69);
            this.txtExpire.Name = "txtExpire";
            this.txtExpire.Size = new System.Drawing.Size(100, 20);
            this.txtExpire.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expire";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1137, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // txtGetAskerUrl
            // 
            this.txtGetAskerUrl.Location = new System.Drawing.Point(6, 19);
            this.txtGetAskerUrl.Name = "txtGetAskerUrl";
            this.txtGetAskerUrl.Size = new System.Drawing.Size(269, 20);
            this.txtGetAskerUrl.TabIndex = 2;
            this.txtGetAskerUrl.Text = "http://localhost:51563/token";
            // 
            // btnGetAsker
            // 
            this.btnGetAsker.Location = new System.Drawing.Point(199, 45);
            this.btnGetAsker.Name = "btnGetAsker";
            this.btnGetAsker.Size = new System.Drawing.Size(76, 23);
            this.btnGetAsker.TabIndex = 0;
            this.btnGetAsker.Text = "Get Asker";
            this.btnGetAsker.UseVisualStyleBackColor = true;
            this.btnGetAsker.Click += new System.EventHandler(this.btnGetAsker_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Url";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1137, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAsker);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnGetAsker);
            this.groupBox2.Controls.Add(this.txtGetAskerUrl);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 236);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Asker";
            // 
            // lstAsker
            // 
            this.lstAsker.FormattingEnabled = true;
            this.lstAsker.Location = new System.Drawing.Point(9, 74);
            this.lstAsker.Name = "lstAsker";
            this.lstAsker.Size = new System.Drawing.Size(266, 69);
            this.lstAsker.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtTokenUrl;
        private System.Windows.Forms.TextBox txtTokenKullaniciAdi;
        private System.Windows.Forms.TextBox txtTokenSifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpire;
        private System.Windows.Forms.TextBox txtGetAskerUrl;
        private System.Windows.Forms.Button btnGetAsker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAsker;
    }
}

