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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isimBox.Text == "1234" && soyisimBox.Text == "1234" && idBox.Text == "1234" && cevapBox.Text == "sanane")
            {
                groupBox2.Visible = true;
                groupBox1.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Informations isnot matched.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            girisPanel girisPanel = new girisPanel();
            this.Hide();
            girisPanel.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
