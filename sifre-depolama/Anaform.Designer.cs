
namespace sifre_depolama
{
    partial class Anaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoşgeldinizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.txt_id_numarasi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_site_url = new System.Windows.Forms.TextBox();
            this.txt_notlar = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kul_adi = new System.Windows.Forms.TextBox();
            this.txt_site_adi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoşgeldinizToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoşgeldinizToolStripMenuItem
            // 
            this.hoşgeldinizToolStripMenuItem.Name = "hoşgeldinizToolStripMenuItem";
            this.hoşgeldinizToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.hoşgeldinizToolStripMenuItem.Text = "Hoş Geldin: ";
            this.hoşgeldinizToolStripMenuItem.Click += new System.EventHandler(this.hoşgeldinizToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_yeni);
            this.groupBox1.Controls.Add(this.txt_id_numarasi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.txt_site_url);
            this.groupBox1.Controls.Add(this.txt_notlar);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.txt_kul_adi);
            this.groupBox1.Controls.Add(this.txt_site_adi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1171, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(969, 239);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(63, 23);
            this.btn_temizle.TabIndex = 15;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.Location = new System.Drawing.Point(365, 53);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(23, 23);
            this.btn_yeni.TabIndex = 14;
            this.btn_yeni.Text = "+";
            this.btn_yeni.UseVisualStyleBackColor = true;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // txt_id_numarasi
            // 
            this.txt_id_numarasi.Location = new System.Drawing.Point(131, 54);
            this.txt_id_numarasi.Name = "txt_id_numarasi";
            this.txt_id_numarasi.ReadOnly = true;
            this.txt_id_numarasi.Size = new System.Drawing.Size(225, 20);
            this.txt_id_numarasi.TabIndex = 13;
            this.txt_id_numarasi.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kayıt No : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(1052, 239);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(63, 23);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(890, 239);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(63, 23);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_site_url
            // 
            this.txt_site_url.Location = new System.Drawing.Point(891, 54);
            this.txt_site_url.Name = "txt_site_url";
            this.txt_site_url.Size = new System.Drawing.Size(225, 20);
            this.txt_site_url.TabIndex = 9;
            this.txt_site_url.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_notlar
            // 
            this.txt_notlar.Location = new System.Drawing.Point(891, 93);
            this.txt_notlar.Multiline = true;
            this.txt_notlar.Name = "txt_notlar";
            this.txt_notlar.Size = new System.Drawing.Size(225, 140);
            this.txt_notlar.TabIndex = 8;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(452, 93);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(225, 20);
            this.txt_sifre.TabIndex = 7;
            // 
            // txt_kul_adi
            // 
            this.txt_kul_adi.Location = new System.Drawing.Point(131, 93);
            this.txt_kul_adi.Name = "txt_kul_adi";
            this.txt_kul_adi.Size = new System.Drawing.Size(225, 20);
            this.txt_kul_adi.TabIndex = 6;
            this.txt_kul_adi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_site_adi
            // 
            this.txt_site_adi.Location = new System.Drawing.Point(452, 54);
            this.txt_site_adi.Name = "txt_site_adi";
            this.txt_site_adi.Size = new System.Drawing.Size(225, 20);
            this.txt_site_adi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notlar : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı veya Mail : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site URL : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site Adı : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1171, 406);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1165, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1171, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Listem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anaform_FormClosing);
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoşgeldinizToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_site_url;
        private System.Windows.Forms.TextBox txt_notlar;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kul_adi;
        private System.Windows.Forms.TextBox txt_site_adi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_id_numarasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.Button btn_temizle;
    }
}

