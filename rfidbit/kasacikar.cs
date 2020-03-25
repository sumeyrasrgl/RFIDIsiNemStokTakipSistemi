using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace rfidbit
{
    public partial class kasacikar : Form
    {
        Enginee nesne = new Enginee();
        public kasacikar()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kasacikar.ActiveForm.Hide();
            anaekran ekrn = new anaekran();
            ekrn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nesne.kasaCikis(textBox1.Text, DateTime.Now.ToString("dd-MM-yyyy"));
            MessageBox.Show("Kasa çıkışı yapıldı.");
            dataGridView1.DataSource = nesne.tumKayitlar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            string giris = serialPort1.ReadLine();
            serialPort1.Close();
            textBox1.Text = giris;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enginee nesne = new rfidbit.Enginee();
            dataGridView1.DataSource = nesne.listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            string giris = serialPort1.ReadLine();
            serialPort1.Close();
            textBox3.Text = giris;
            Enginee nesne = new rfidbit.Enginee();
            dataGridView1.DataSource = nesne.cikisAra(textBox3.Text);
        }
    }
}
