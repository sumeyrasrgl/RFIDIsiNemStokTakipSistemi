﻿using System;
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
    public partial class isitakip : Form
    {
        public isitakip()
        {
            InitializeComponent();
            serialPort1.Open();
            timer1.Interval = 4000;
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isitakip.ActiveForm.Hide();
            anaekran ekrn = new anaekran();
            ekrn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            string giris = serialPort1.ReadLine().ToString();
            string[] pot = giris.Split('*');
       

            textBox1.Text = pot[0];
            textBox2.Text = pot[1];
            textBox3.Text = pot[2];

            //serialPort1.DiscardInBuffer();

        }
    }
}
