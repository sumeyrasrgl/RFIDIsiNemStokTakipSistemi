using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;


namespace rfidbit
{
    class Enginee
    {
        MySqlConnection baglanti()
        {
            MySqlConnection baglan = new MySqlConnection("Server=127.0.0.1; Database=rfiddb;uid=root;pwd=root");
            baglan.Open();
            return baglan;
        }

        public void kasaKaydet ( string kasaTur, string kasaID, string girisTarih)
        {
            string sql = "INSERT INTO kasaekle(kasaTur,kasaID,girisTarih)";
            sql += "VALUES(@kasaTur,@kasaID,@girisTarih)";
            MySqlCommand komut = new MySqlCommand(sql, baglanti());
            komut.Parameters.AddWithValue("@kasaTur", kasaTur);
            komut.Parameters.AddWithValue("@kasaID", kasaID);
            komut.Parameters.AddWithValue("@girisTarih", girisTarih);
            komut.ExecuteNonQuery();
            baglanti().Close();
           
        }

        public DataTable tumKayitlar()
        {
            string sql = "SELECT * FROM kasaekle ORDER BY girisTarih";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, baglanti());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti().Close();
            return dt;
        }

        
        public void kayitSil( string kasaID)
        {
            string sql = " DELETE FROM kasaekle WHERE kasaID=@kasaID";
            MySqlCommand komut = new MySqlCommand(sql, baglanti());
            komut.Parameters.AddWithValue("@kasaID", kasaID);
            komut.ExecuteNonQuery();
            baglanti().Close();
        }

        public DataTable kayitBul(string kasaID)
        {
            string sql = "SELECT * FROM kasaekle WHERE kasaID=@kasaID";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, baglanti());
            adp.SelectCommand.Parameters.AddWithValue("@kasaID", kasaID);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti().Close();
            return dt;
        }

        public void kasaCikis( string kasaID, string cikisTarih)
        {
            string sql = "INSERT INTO kasacikar(kasaID,cikisTarih)";
            sql += "VALUES(@kasaID,@cikisTarih)";
            MySqlCommand komut = new MySqlCommand(sql, baglanti());
            komut.Parameters.AddWithValue("@kasaID", kasaID);
            komut.Parameters.AddWithValue("@cikisTarih", cikisTarih);
            komut.ExecuteNonQuery();
            baglanti().Close();

        }

        private void kasacikar(object sender, EventArgs e)
        {
           
            string sql = "SELECT * FROM kasacikar ORDER BY cikisTarih";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, baglanti());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti().Close();
            
        }
        public DataTable listele()
        {
            string sql = "SELECT kasacikar.kasaID, cikisTarih, girisTarih FROM kasacikar JOIN kasaekle ON kasacikar.kasaID = kasaekle.kasaID";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, baglanti());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti().Close();
            return dt;
        }

        public DataTable cikisAra(string kasaID)
        {
            string sql = "SELECT * FROM kasacikar WHERE kasaID=@kasaID";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, baglanti());
            adp.SelectCommand.Parameters.AddWithValue("@kasaID", kasaID);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti().Close();
            return dt;
        }

        
    }
}
