using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rfidbit
{
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            kasaekle nesne = new kasaekle();
            nesne.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            kasacikar nesne = new kasacikar();
            nesne.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mailgonder nesne = new mailgonder();
            nesne.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            isitakip nesne = new isitakip();
            nesne.ShowDialog();
        }
    }
}
