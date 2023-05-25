using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifre_depolama
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }


        private void Anaform_Load(object sender, EventArgs e)
        {
            txt_id_numarasi.Text = "0";
            hoşgeldinizToolStripMenuItem.Text += CLS.mySstm.Aktif_Kullanici_Adi;
            Grid_Doldur();
        }


        private void Grid_Doldur()
        {
            dataGridView1.DataSource = CLS.SQLConnectionClass.Table("select * from SIFRELER");
            dataGridView1.Columns[0].HeaderText = "Kayıt No";
            dataGridView1.Columns[1].HeaderText = "Site Adı";
            dataGridView1.Columns[2].HeaderText = "Site URL";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı Adı veya Mail";
            dataGridView1.Columns[4].HeaderText = "Şifre";
            dataGridView1.Columns[5].HeaderText = "Notlar";
            dataGridView1.Columns[6].HeaderText = "Kayıt Etme Tarihi ve Saati";
            dataGridView1.Columns[7].HeaderText = "Güncelleme Tarihi ve Saati";

           
        }


        private void Anaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?" +
                "                   Kaydedilmemiş Bilgileriniz Silinebilir!", "Çıkış Yapıyorsunuz!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (x == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }

        private void hoşgeldinizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MYMODELS.SIFRELER.SIFRE_Sil(Convert.ToInt32(txt_id_numarasi.Text));
            Temizle();
            Grid_Doldur();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            MYMODELS.SIFRELER.SIFRE sif = new MYMODELS.SIFRELER.SIFRE()
            {
                sif_RECno = Convert.ToInt32(txt_id_numarasi.Text),
                sif_kul_adi_mail = txt_kul_adi.Text,
                sif_kul_sifre = txt_sifre.Text,
                sif_notlar = txt_notlar.Text,
                sif_site_adi = txt_site_adi.Text,
                sif_site_url = txt_site_url.Text,
             };
            txt_id_numarasi.Text = MYMODELS.SIFRELER.SIFRE_Kaydet(sif).ToString();
            Grid_Doldur();


            
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            txt_id_numarasi.Text = "0";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_id_numarasi.Text = row.Cells["sif_RECno"].Value.ToString();
                txt_kul_adi.Text = row.Cells["sif_kul_adi_mail"].Value.ToString();
                txt_sifre.Text = row.Cells["sif_kul_sifre"].Value.ToString();
                txt_notlar.Text = row.Cells["sif_notlar"].Value.ToString();
                txt_site_adi.Text = row.Cells["sif_site_adi"].Value.ToString();
                txt_site_url.Text = row.Cells["sif_site_url"].Value.ToString();


                
            }




        }

      



        void Temizle()
        {
            txt_id_numarasi.Text = "0";
            txt_kul_adi.Text = "";
            txt_sifre.Text = "";
            txt_notlar.Text = "";
            txt_site_adi.Text = "";
            txt_site_url.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }




    }
    }


