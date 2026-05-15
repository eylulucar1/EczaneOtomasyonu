using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EczaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                try
                {
                    var path = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), "EczaneDesignerError.txt");
                    System.IO.File.WriteAllText(path, ex.ToString());
                }
                catch { }
                throw;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Formu kapatır.
        }
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDb.accdb");
        void Listele()
        {
            // INSERT yerine SELECT sorgusu kullanmalısın
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Satislar", con);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();

            // Bağlantıyı açmayı unutma (eğer globalde açık değilse)
            if (con.State == ConnectionState.Closed) con.Open();

            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTcNo.Text == "" || txtBarkodNo.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz giriniz!", "Eksik Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool sonuc1 = false;
                bool sonuc2 = false;
                int toplamfiyat = 0,fyt=0;
                OleDbCommand komut1 = new OleDbCommand("select *from Hastalar where TcNO = @p1", con);
                con.Open();
                komut1.Parameters.AddWithValue("@p1",txtTcNo.Text);
                OleDbDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                {
                    sonuc1 = true;
                }
                con.Close();
                OleDbCommand komut2 = new OleDbCommand("select *from İlaclar where barkodNo = @p1", con);
                con.Open();
                komut1.Parameters.AddWithValue("@p1", txtBarkodNo.Text);
                OleDbDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    fyt = int.Parse(dr2["fiyat"].ToString());
                    sonuc2 = true;
                }
                con.Close();

                if (!sonuc1)
                    MessageBox.Show("Lütfen önce hasta kaydını yapınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!sonuc2)
                    MessageBox.Show("Lütfen önce ilaç kaydını yapınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    OleDbCommand komut = new OleDbCommand("insert into Satislar (satisNo,hastaNo,ilacNo,adet,toplamFiyat,tarih,durum) values(@p1,@p2,@p3,@p4,@p5,@p6)", con);
                    con.Open();
                    toplamfiyat = fyt * int.Parse(numAdet.Value.ToString());
          
                    komut.Parameters.AddWithValue("@p1", txtTcNo.Text);
                    komut.Parameters.AddWithValue("@p2", txtBarkodNo.Text);
                    komut.Parameters.AddWithValue("@p3", numAdet.Value);
                    komut.Parameters.AddWithValue("@p4", toplamfiyat);
                    komut.Parameters.AddWithValue("@p5", DateTime.Today);
                    komut.Parameters.AddWithValue("@p6", true);
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Toplam Fiyat : " + toplamfiyat);
                        MessageBox.Show("Satış Yapıldı", "Satış");
                    }
                    else
                    {
                        MessageBox.Show("Satış işleminde hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }

                Listele();
            }
        }

        private void hastaKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaKaydi fr = new FrmHastaKaydi();
            fr.Show();
        }

        private void hastalarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaListesi fr = new FrmHastaListesi();
            fr.Show();
        }

        private void hastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaSil fr = new FrmHastaSil();
            fr.Show();
        }

        private void hastaGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaGuncelle fr = new FrmHastaGuncelle();
            fr.Show();
        }
       

        private void ilaçKaydıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmIlacKaydet frm = new FrmIlacKaydet();
            frm.Show();
        }

        private void ilaçlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmİlacListele fr = new FrmİlacListele();
            fr.Show();
        }

        private void ilaçSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmİlacSil fr = new FrmİlacSil();
            fr.Show();
        }

        private void ilaçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmİlacGuncel fr = new FrmİlacGuncel();
            fr.Show();
        }

        private void güvenceEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGuvenceEkle frmGuvenceEkle = new FrmGuvenceEkle();
            frmGuvenceEkle.Show();  
        }
    }
}
