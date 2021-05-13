using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duaxe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2 a = new Form2();
            //a.Show();
            //this.Close();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Show();//tat form 2, button form 1 se hien lai
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
