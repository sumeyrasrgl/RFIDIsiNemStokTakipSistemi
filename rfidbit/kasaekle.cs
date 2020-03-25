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
    public partial class kasaekle : Form
    {
        Enginee nesne = new Enginee();

        public kasaekle()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kasaekle.ActiveForm.Hide();
            anaekran ekrn = new anaekran();
            ekrn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            string giris = serialPort1.ReadLine();
            serialPort1.Close();
            textBox1.Text = giris;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nesne.kasaKaydet(comboBox1.Text,textBox1.Text, DateTime.Now.ToString("dd-MM-yyyy"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enginee nesne = new rfidbit.Enginee();
            dataGridView1.DataSource = nesne.tumKayitlar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Enginee nesne = new rfidbit.Enginee();
            nesne.kayitSil(textBox3.Text);
            MessageBox.Show("Silindi.");
            dataGridView1.DataSource = nesne.tumKayitlar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            string giris = serialPort1.ReadLine();
            serialPort1.Close();
            textBox3.Text = giris;
            Enginee nesne = new rfidbit.Enginee();
            dataGridView1.DataSource = nesne.kayitBul(textBox3.Text);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
