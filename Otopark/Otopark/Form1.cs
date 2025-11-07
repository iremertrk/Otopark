using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otopark
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ArabaParkDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form1_Load(object sender, EventArgs e)
        {
            uyeler();
            fill();
            odemeler();
            doluMu();

        }

        private void fill()
        { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select AracSahibi, Plaka from ArabaKayitTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AracSahibi, Plaka",typeof(string));
            dt.Load(rdr);

            komut = new SqlCommand("select distinct AracSahibi, Plaka from ArabaKayitTbl", baglanti);
            rdr = komut.ExecuteReader();
            DataTable dttek = new DataTable();
            dttek.Columns.Add("AracSahibi, Plaka", typeof(string));
            dttek.Load(rdr);

            AracSahibiCb.ValueMember = "AracSahibi";
            PlakaCb.ValueMember = "Plaka";
            AracSahibiCb.DataSource = dttek;
            PlakaCb.DataSource = dttek;
            baglanti.Close();
        
        }
        private void uyeler()
        { 
            baglanti.Open();
            string query = "select * from ArabaKayitTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            kayitDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void odemeler()
        {
            baglanti.Open();
            string query = "select * from OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        
        private void temizle()
        {
            AracSahibiCb.Text = "";
            PlakaCb.Text = "";
            TutarTb.Text = "";
            CikisTb.Text = "";
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton1.FillColor == Color.LawnGreen) 
            {
                guna2CircleButton1.FillColor = Color.Red;
                pictureBox9.Visible = true;
            }
            else 
            {
                guna2CircleButton1.FillColor = Color.LawnGreen;
                pictureBox9.Visible = false;
            }
            doluMu();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton2.FillColor == Color.LawnGreen)
            {
                guna2CircleButton2.FillColor = Color.Red;
                pictureBox2.Visible = true;
            }
            else
            {
                guna2CircleButton2.FillColor = Color.LawnGreen;
                pictureBox2.Visible = false;
            }
            doluMu();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton3.FillColor == Color.LawnGreen)
            {
                guna2CircleButton3.FillColor = Color.Red;
                pictureBox3.Visible = true;
            }
            else
            {
                guna2CircleButton3.FillColor = Color.LawnGreen;
                pictureBox3.Visible = false;
            }
            doluMu();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            if (guna2CircleButton4.FillColor == Color.LawnGreen)
            {
                guna2CircleButton4.FillColor = Color.Red;
                pictureBox4.Visible = true;
            }
            else
            {
                guna2CircleButton4.FillColor = Color.LawnGreen;
                pictureBox4.Visible = false;
            }
            doluMu();
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {

            if (guna2CircleButton5.FillColor == Color.LawnGreen)
            {
                guna2CircleButton5.FillColor = Color.Red;
                pictureBox5.Visible = true;
            }
            else
            {
                guna2CircleButton5.FillColor = Color.LawnGreen;
                pictureBox5.Visible = false;
            }
            doluMu();
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {

            if (guna2CircleButton6.FillColor == Color.LawnGreen)
            {
                guna2CircleButton6.FillColor = Color.Red;
                pictureBox6.Visible = true;
            }
            else
            {
                guna2CircleButton6.FillColor = Color.LawnGreen;
                pictureBox6.Visible = false;
            }
            doluMu();
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {

            if (guna2CircleButton7.FillColor == Color.LawnGreen)
            {
                guna2CircleButton7.FillColor = Color.Red;
                pictureBox7.Visible = true;
            }
            else
            {
                guna2CircleButton7.FillColor = Color.LawnGreen;
                pictureBox7.Visible = false;
            }
            doluMu();
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {

            if (guna2CircleButton8.FillColor == Color.LawnGreen)
            {
                guna2CircleButton8.FillColor = Color.Red;
                pictureBox8.Visible = true;
            }
            else
            {
                guna2CircleButton8.FillColor = Color.LawnGreen;
                pictureBox8.Visible = false;
            }
            doluMu();
        }


        public void doluMu()
        {
            if (guna2CircleButton1.FillColor == Color.LawnGreen ||
                guna2CircleButton2.FillColor == Color.LawnGreen ||
                guna2CircleButton3.FillColor == Color.LawnGreen ||
                guna2CircleButton4.FillColor == Color.LawnGreen ||
                guna2CircleButton5.FillColor == Color.LawnGreen ||
                guna2CircleButton6.FillColor == Color.LawnGreen ||
                guna2CircleButton7.FillColor == Color.LawnGreen ||
                guna2CircleButton8.FillColor == Color.LawnGreen)
            {
                label9.Text = "Boş Yer Mevcut";
            }
            else
            {
                label9.Text = "Otopark Dolu";
            }
        }
        
        // EKLEME
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (AracSahibiTb.Text == "" || TelefonTb.Text == "" || TarihDtp.Text == "" || PlakaTb.Text == "" || GirisTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else 
            { 
                try
                {

                    baglanti.Open();
                    string query = "insert into ArabaKayitTbl values('" + AracSahibiTb.Text + "','" + TelefonTb.Text + "','" + TarihDtp.Text + "','" + PlakaTb.Text + "','" + GirisTb.Text + "',NULL)";
                    SqlCommand komut= new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Kaydı Başarıyla Eklenmiştir");
                    baglanti.Close();
                    uyeler();
                    fill();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int AracKey;
        // SİLME
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            
            if (AracSahibiTb.Text == "" || TelefonTb.Text == "" || TarihDtp.Text == "" || PlakaTb.Text == "" || GirisTb.Text == "")
            {
                MessageBox.Show("Silinecek Kaydı Seçiniz");
            }
            else
            {
                AracKey = Convert.ToInt32(kayitDgv.SelectedRows[0].Cells[0].Value.ToString());

                try
                {

                    baglanti.Open();
                    string query = "delete from ArabaKayitTbl where AKayitId="+AracKey+"";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Kaydı Başarıyla Silinmiştir");
                    baglanti.Close();
                    uyeler();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void kayitDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AracKey = Convert.ToInt32(kayitDgv.SelectedRows[0].Cells[0].Value.ToString());
            AracSahibiTb.Text = kayitDgv.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = kayitDgv.SelectedRows[0].Cells[2].Value.ToString();
            TarihDtp.Text = kayitDgv.SelectedRows[0].Cells[3].Value.ToString();
            PlakaTb.Text=kayitDgv.SelectedRows[0].Cells[4].Value.ToString();
            GirisTb.Text = kayitDgv.SelectedRows[0].Cells[5].Value.ToString();
        }
        //GUNCELLEME
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (AracSahibiTb.Text == "" || TelefonTb.Text == "" || TarihDtp.Text == "" || PlakaTb.Text == "" || GirisTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {

                    baglanti.Open();
                    string query = "update ArabaKayitTbl set AracSahibi='" + AracSahibiTb.Text + "',Telefon='" + TelefonTb.Text + "',Tarih='" + TarihDtp.Text + "',Plaka='" + PlakaTb.Text + "',Giris='" + GirisTb.Text + "' where AKayitId="+AracKey+"";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Kaydı Başarıyla Güncellenmiştir");
                    baglanti.Close();
                    uyeler();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AracSahibiTb.Text = "";
            TelefonTb.Text = "";
            TarihDtp.Text = "";
            PlakaTb.Text = "";
            GirisTb.Text = "";

        }


        
        //ODEME
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (AracSahibiCb.Text == "" || PlakaCb.Text == "" || TutarTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {

                    baglanti.Open();
                    string query = "insert into OdemeTbl values('" + AracSahibiCb.Text + "','" + PlakaCb.Text + "','" + TutarTb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();


                    query = "update ArabaKayitTbl set Cikis = '" + CikisTb.Text + "' where AracSahibi = '"+AracSahibiCb.Text+"' and Cikis is NULL";
                    komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();

                    //update ArabaKayitTbl set Cikis = '13.30' where AracSahibi = 'İrem Ertürk' and Cikis is NULL;

                    MessageBox.Show("Ödeme İşlemi Tamamlanmıştır");
                    baglanti.Close();
                    odemeler();
                    uyeler();



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        // HESAPLA
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            double z;
            if (CikisTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }


            var index2 = CikisTb.Text.IndexOf(".");
            var saat2 = CikisTb.Text.Substring(0, index2);
            var dakika2 = CikisTb.Text.Substring(index2 + 1);

            var bitSaat = Convert.ToInt16(saat2);
            var bitDk = Convert.ToInt16(dakika2);

            var bas = 0;
            string giris ="";
            if (GirisTb.Text == "") {
                try
                {

                    baglanti.Open();
                    string query = "select * from ArabaKayitTbl ak where  ak.AracSahibi = '" + AracSahibiCb.Text + "' and ak.Cikis is NULL ";
                    // select * from ArabaKayitTbl ak where  ak.AracSahibi = 'İrem Ertürk' 
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    SqlDataReader reader = komut.ExecuteReader();

                    if (reader.Read())
                    {
                        giris = reader["Giris"].ToString();
                    }

                    baglanti.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
            else
            {
                giris = GirisTb.Text;
                
            }

            var index = giris.IndexOf(".");
            var saat = giris.Substring(0, index);
            var dakika = giris.Substring(index + 1);

            var basSaat = Convert.ToInt16(saat);
            var basDk = Convert.ToInt16(dakika);

            bas = basSaat * 60 + basDk;

            var bit = bitSaat * 60 + bitDk;

            z = bit - bas;
            if(z <= 60)
            {
                TutarTb.Text = "30";
            }
            if (z > 60 && z<=180)
            {
                TutarTb.Text = "60";
            }
            if (z > 180 && z <= 300)
            {
                TutarTb.Text = "85";
            }
            if (z > 300)
            {
                TutarTb.Text = "100";
            }

        }

    }
}
