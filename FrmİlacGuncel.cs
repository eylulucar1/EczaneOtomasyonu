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
    public partial class FrmİlacGuncel : Form
    {
        public FrmİlacGuncel()
        {
            InitializeComponent();
        }

        private void FrmİlacGuncel_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDb.accdb");

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from İlaclar where barkodNo = " + txtNumara.Text + "", con);

            con.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtAdres.Text = dr[2].ToString();
                txtFiyat.Text = dr[3].ToString();
                txtAdet.Text = dr[4].ToString();
                cbDurum.Checked = bool.Parse(dr[5].ToString()) ? true : false;
            }
            else
            {
                MessageBox.Show("Aradığınız kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtNumara.Text == "" || txtAdres.Text == "" || txtFiyat.Text == ""|| txtAdet.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("update İlaclar set ilacAdi = @p1,firmaAdi= @p2,fiyat=@p3,adet=@p4,durum=@p5 where barkodNo = @p6", con);
                con.Open();
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtAdres.Text);
                komut.Parameters.AddWithValue("@p3", txtFiyat.Text);
                komut.Parameters.AddWithValue("@p4", txtAdet.Text);
                komut.Parameters.AddWithValue("@p5", cbDurum.Checked ? true : false);
                komut.Parameters.AddWithValue("@p6", txtNumara.Text);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show(txtNumara.Text + " numaralı kayıt güncellendi");
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                con.Close();
                txtAd.Text = "";
                txtAdres.Text = "";
                txtNumara.Text = "";
                txtFiyat.Text = "";
                txtAdet.Text = "";
            }
        }
    }
}
