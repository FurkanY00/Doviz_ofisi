using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace Doviz_ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-KPC6PV7\\SQLEXPRESS;Initial Catalog=dovız_ofisi;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolaralis.Text = dolaralıs;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolarsatis.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroalis.Text = euroalis;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosatis.Text = eurosatis;

            baglantı.Open();
            SqlDataAdapter da =new SqlDataAdapter("select euro,dolar from tbl_kasa", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();
        }
        private void btndolaral_Click(object sender, EventArgs e)
        {
            //kasadaki doları cekme 
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select dolar from tbl_kasa ", baglantı);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                label15.Text = rdr["dolar"].ToString();
            }
            baglantı.Close();
            //işlem sonucu oluşan miktarı bulma 
            int para;
            int islem;
            //sonucu veri tabanına yazma
            para = Convert.ToInt16(label15.Text);
            islem = Convert.ToInt16(txtmiktar.Text);
            int sonuc = para + islem;
            baglantı.Open();
            SqlCommand kmt = new SqlCommand("update tbl_kasa set dolar=@p1  where id=1 ", baglantı);
            kmt.Parameters.AddWithValue("@p1", sonuc);
            kmt.ExecuteNonQuery();
            baglantı.Close();

            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select euro,dolar from tbl_kasa", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();
            //tl hesaplama 

           /* baglantı.Open();
            int dolarkasa,tlkasa;
            SqlCommand cmd = new SqlCommand("select dolar from tbl_kasa", baglantı);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                
                label17.Text = sdr["dolar"].ToString();
            }
            baglantı.Close();
            dolarkasa = label16.Text;
     
            tlkasa=((dolarkasa*Convert.ToInt16(txtkur.Text)));
            baglantı.Open();
            SqlCommand sql=new SqlCommand("Update tbl_kasa set TL=@p1 where id=1",baglantı);
            sql.Parameters.AddWithValue("@p1", tlkasa);
            sql.ExecuteNonQuery();
            baglantı.Close();*/




        }

        private void btndolarsat_Click(object sender, EventArgs e)
        {
            //kasadaki doları cekme 
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select dolar from tbl_kasa ", baglantı);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                label15.Text = rdr["dolar"].ToString();
            }
            baglantı.Close();
            //işlem sonucu oluşan miktarı bulma 
            int para;
            int islem;
            //sonucu veri tabanına yazma
            para = Convert.ToInt16(label15.Text);
            islem = Convert.ToInt16(txtmiktar.Text);
            int sonuc = para - islem;
            baglantı.Open();
            SqlCommand kmt = new SqlCommand("update tbl_kasa set dolar=@p1  where id=1 ", baglantı);
            kmt.Parameters.AddWithValue("@p1", sonuc);
            kmt.ExecuteNonQuery();
            baglantı.Close();

            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select euro,dolar from tbl_kasa", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();
        }

        private void btneuroal_Click(object sender, EventArgs e)
        {
            //kasadaki euro cekme 
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select euro from tbl_kasa ", baglantı);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                label15.Text = rdr["euro"].ToString();
            }
            baglantı.Close();
            //işlem sonucu oluşan miktarı bulma 
            int para;
            int islem;
            //sonucu veri tabanına yazma
            para = Convert.ToInt16(label15.Text);
            islem = Convert.ToInt16(txtmiktar.Text);
            int sonuc = para + islem;
            baglantı.Open();
            SqlCommand kmt = new SqlCommand("update tbl_kasa set euro=@p1  where id=1 ", baglantı);
            kmt.Parameters.AddWithValue("@p1", sonuc);
            kmt.ExecuteNonQuery();
            baglantı.Close();

            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select euro,dolar from tbl_kasa", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();
        }

        private void btneurosat_Click(object sender, EventArgs e)
        {
            //kasadaki euro cekme 
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select euro from tbl_kasa ", baglantı);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                label15.Text = rdr["euro"].ToString();
            }
            baglantı.Close();
            //işlem sonucu oluşan miktarı bulma 
            int para;
            int islem;
            //sonucu veri tabanına yazma
            para = Convert.ToInt16(label15.Text);
            islem = Convert.ToInt16(txtmiktar.Text);
            int sonuc = para - islem;
            baglantı.Open();
            SqlCommand kmt = new SqlCommand("update tbl_kasa set euro=@p1  where id=1 ", baglantı);
            kmt.Parameters.AddWithValue("@p1", sonuc);
            kmt.ExecuteNonQuery();
            baglantı.Close();

            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select euro,dolar from tbl_kasa", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur=Convert.ToDouble(txtkur.Text);
            miktar=Convert.ToDouble(txtmiktar.Text);
            tutar = kur * miktar;
            txttutar.Text = tutar.ToString();

          


        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
        txtkur.Text=txtkur.Text.Replace(".",",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = "ADET";
            double kur=Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(txtmiktar.Text);
            int tutar =Convert.ToInt32(miktar/kur);
            txttutar .Text = tutar.ToString();
            txtkalan.Text = Convert.ToString(tutar-miktar);
            int kalan;
            kalan = miktar % Convert.ToInt32(kur);
            txtkalan.Text = kalan.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            txtkur.Text = lbldolaralis.Text;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsatis.Text;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroalis.Text;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosatis.Text;

        }
    }
}
