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
    public partial class isKaynaklari : Form
    {
        public isKaynaklari()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			
		}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // radioButton1.Checked = false;
            groupBox1.Visible = true;
        }

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			groupBox2.Visible = true;
		}
	}
}
