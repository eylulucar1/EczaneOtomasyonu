using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonu
{
    public partial class FrmIlacKaydet : Form
    {
        public FrmIlacKaydet()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDb.accdb");

       
        private void FrmIlacKaydet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtFirma.Text == "" || txtAdet.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                using (var con = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=EczaneDb.accdb"))
                using (var komut = new OleDbCommand(
                    "INSERT INTO İlaclar (ilacAdi, FirmaAdi, fiyat, adet, durum) VALUES (?, ?, ?, ?, ?)", con))
                {
                    con.Open();
                    komut.Parameters.AddWithValue("p1", txtAd.Text);           // sıraya dikkat
                    komut.Parameters.AddWithValue("p2", txtFirma.Text);
                    komut.Parameters.AddWithValue("p3", decimal.TryParse(txtFiyat.Text, out var f) ? (object)f : DBNull.Value);
                    komut.Parameters.AddWithValue("p4", int.TryParse(txtAdet.Text, out var a) ? (object)a : DBNull.Value);
                    komut.Parameters.AddWithValue("p5", true);
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt tamamlandı!");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt hatası !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
                
            }
            txtAd.Text = "";
            txtFirma.Text = "";
            txtAdet.Text = "";
            txtFiyat.Text = "";
        }
    }
}

