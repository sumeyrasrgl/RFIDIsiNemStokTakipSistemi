using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace rfidbit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.FromArgb(205,102,29);
            textBox1.ForeColor = Color.FromArgb(255,255,255);

            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel2.BackColor = Color.FromArgb(205, 102, 29);
            textBox2.ForeColor = Color.FromArgb(255, 255, 255);

            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string sql = "select * from login where kullaniciAdi=@kullaniciAdi and sifre=@sifre";
            String ccon = "Server=127.0.0.1; Database=rfiddb;uid=root;pwd=root";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, ccon);
            adp.SelectCommand.Parameters.AddWithValue("kullaniciAdi", textBox1.Text);
            adp.SelectCommand.Parameters.AddWithValue("sifre", textBox2.Text);
            
            DataTable dt = new DataTable();

            adp.Fill(dt);

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }
            else
            {
                this.Hide();
                anaekran nesne = new anaekran();
                nesne.ShowDialog();
            }
        }
    }
}
