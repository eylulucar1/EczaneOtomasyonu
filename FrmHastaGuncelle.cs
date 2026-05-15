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
    public partial class FrmHastaGuncelle : Form
    {
        public FrmHastaGuncelle()
        {
            InitializeComponent();
        }

        private void FrmHastaGuncelle_Load(object sender, EventArgs e)
        {
            guvenceGetir();
        }
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDb.accdb");
        public void guvenceGetir()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Guvence", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            cbGuvence.ValueMember = "guvenceNo";
            cbGuvence.DisplayMember = "guvenceAdi";
            cbGuvence.DataSource = tablo;


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Hastalar where TcNO = '" + txtNumara.Text + "'", con);
            
            con.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtAdres.Text = dr[2].ToString();
                txtTel.Text = dr[3].ToString();
                cbGuvence.SelectedValue = dr[4].ToString();
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
            if (txtAd.Text == "" || txtNumara.Text == "" || txtAdres.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("update Hastalar set adSoyad = @p1,adres= @p2,tel=@p3,guvence=@p4,durum=@p5 where TcNO = @p6", con);
                con.Open();
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtAdres.Text);
                komut.Parameters.AddWithValue("@p3", txtTel.Text);
                komut.Parameters.AddWithValue("@p4", cbGuvence.SelectedValue);
                komut.Parameters.AddWithValue("@p5", cbDurum.Checked ? true : false);
                komut.Parameters.AddWithValue("@p6",txtNumara.Text);
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
                txtTel.Text = "";
            }
            
        }
    }
}
