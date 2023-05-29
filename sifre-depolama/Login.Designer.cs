
namespace sifre_depolama
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.bttn_cikis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kodu :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Location = new System.Drawing.Point(99, 83);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullanici_adi.TabIndex = 2;
            this.txt_kullanici_adi.TextChanged += new System.EventHandler(this.txt_kullanici_adi_TextChanged);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(99, 123);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(99, 166);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(100, 23);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_cikis
            // 
            this.bttn_cikis.Location = new System.Drawing.Point(99, 195);
            this.bttn_cikis.Name = "bttn_cikis";
            this.bttn_cikis.Size = new System.Drawing.Size(100, 23);
            this.bttn_cikis.TabIndex = 5;
            this.bttn_cikis.Text = "Çıkış";
            this.bttn_cikis.UseVisualStyleBackColor = true;
            this.bttn_cikis.Click += new System.EventHandler(this.bttn_cikis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giriş Yap";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(221, 277);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttn_cikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kullanici_adi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button bttn_cikis;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}