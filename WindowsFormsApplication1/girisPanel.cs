using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class girisPanel : Form
    {
        String id = "1234";
        String pass = "1234";



        public girisPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (agreementPolicy.Checked == true)
            {
                if (textBox1.Text == id && textBox2.Text == pass )
                {
                    string kullanici = "";
                    if (yonetici.Checked)
                    {
                        kullanici = "Yönetici";
                    }
                    else if (muhasebe.Checked)
                    {
                        kullanici = "Muhasebe";
                    }
                    else if(insanKaynaklari.Checked)
                    {
                        kullanici = "İnsan Kaynakları";
                    }
                    else
                    {
                        kullanici = "Personel";
                    }
                    //



                    Form2 form2 = new Form2(kullanici);
                    form2.Show();
                    this.Hide();

                    
                   
                }
                else
                {
                    MessageBox.Show("Geçerli kullanıcı adı ve şifre değil.\nŞifrenizi unuttuysanız, Şifremi Unuttuma tıklayın");
                }
            }
            else
            {
                MessageBox.Show("Lütfen agreement and policy onaylayın!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (agreementPolicy.Checked == true)
            {
                MessageBox.Show("Paneldeki bilgileri kimseyle paylaşma!");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void girisPanel_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 form8gecis = new Form8();
            this.Hide();
            form8gecis.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.Hide();
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
