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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = CLS.SQLConnectionClass.Table("select * from KULLANICILAR where kul_kod = '"+ txt_kullanici_adi.Text + "' and kul_pw= '" + txt_sifre.Text + "'");
            if (dt.Rows.Count > 0 )
            {


                this.Hide();
                new Anaform().ShowDialog();
                
            }
            else
            {
                MessageBox.Show("bilgiler hatalı");



            }
        
           
        }

        private void bttn_cikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kullanici_adi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
