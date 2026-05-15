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
    public partial class FrmHastaKaydi : Form
    {
        public FrmHastaKaydi()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmHastaKaydi_Load(object sender, EventArgs e)
        {
            guvenceGetir();
        }
        public int tcVarmi(string tc)
        {
            int sonuc = 1;
            OleDbCommand komut1 = new OleDbCommand("select *from Hastalar where TcNO = @p1", con);
            con.Open();
            komut1.Parameters.AddWithValue("@p1", tc);
            OleDbDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                sonuc = 0;
            }
            con.Close();
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtNo.Text == "" || txtAdres.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int tcSonuc = tcVarmi(txtNo.Text);
                if(tcSonuc == 0)
                {
                    MessageBox.Show(txtNo.Text + "Numaralı kayıt zaten var", "Kayıt hatası", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                OleDbCommand komut = new OleDbCommand("insert into Hastalar values (@p1,@p2,@p3,@p4,@p5,@p6)",con);
                con.Open();
                komut.Parameters.AddWithValue("@p1",txtNo.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", txtAdres.Text);
                komut.Parameters.AddWithValue("@p4", txtTel.Text);
                komut.Parameters.AddWithValue("@p5", cbGuvence.SelectedValue);
                komut.Parameters.AddWithValue("@p6", true);
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
            txtNo.Text = "";
            txtAd.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
        }

        private void cbGuvence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
