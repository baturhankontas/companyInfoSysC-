using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
       
        kisiselBilgiler kisiselBil = new kisiselBilgiler();
        isKaynaklari isKaynak = new isKaynaklari();
      
        public Form2(string kullanici)
        {
            InitializeComponent();

            if (kullanici == "Muhasebe")
            {
                button2.Visible = false;
            }
            if (kullanici == "İnsan Kaynakları")
            {
                button3.Visible = false;
            }
            if (kullanici == "Personel")
            {
                button2.Visible = false;
                button3.Visible = false;
            }

            label2.Text = DateTime.Now.ToString("HH:mm:ss");
            label3.Text = kullanici + " olarak giriş yapıldı.";
            
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            kisiselBil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isKaynak.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
