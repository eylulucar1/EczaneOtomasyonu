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
    public partial class FrmGuvenceEkle : Form
    {
        public FrmGuvenceEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDb.accdb");


        private void FrmGuvenceEkle_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("Lütfen güvence adını giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // If demo mode is enabled, save to in-memory demo store instead of the real database.
                if (DemoConfig.IsDemo)
                {
                    DemoData.AddGuvence(txtAd.Text, true);
                    MessageBox.Show("Demo modu: Kayıt demo veritabanına eklendi.");
                }
                else
                {
                    using (var con = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=EczaneDb.accdb"))
                    using (var komut = new OleDbCommand(
                        "INSERT INTO Guvence (guvenceAdi, durum) VALUES (@p1,@p2)", con))
                    {
                        con.Open();
                        komut.Parameters.AddWithValue("p1", txtAd.Text);
                        komut.Parameters.AddWithValue("p2", true);
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

            }
            txtAd.Text = "";
        }
    }
}
