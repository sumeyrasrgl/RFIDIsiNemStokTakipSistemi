using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace rfidbit
{
    public partial class mailgonder : Form
    {
        public mailgonder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string DosyaYolu;
        
        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("sumeyrasarigull@gmail.com", "68785524Simsim");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(textBox2.Text.ToString(), textBox1.Text.ToString());
            mail.To.Add("sumeyrasarigull@gmail.com");
            mail.Subject = textBox3.Text.ToString();
            mail.IsBodyHtml = true;
            mail.Body = textBox4.Text.ToString();

            sc.Send(mail);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mailgonder.ActiveForm.Hide();
            anaekran ekrn = new anaekran();
            ekrn.ShowDialog();
        }

       
    }
}
