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
    public partial class FrmİlacSil : Form
    {
        public FrmİlacSil()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDb.accdb");
        public void Listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from İlaclar where durum = true", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void FrmİlacSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from İlaclar where durum = true and barkodNo = " + txtNumara.Text + "", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("update İlaclar set durum = false where barkodNo = @p1", con);
            con.Open();
            komut.Parameters.AddWithValue("@p1", txtNumara.Text);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show(txtNumara.Text + " numaralı kayıt silindi");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            con.Close();
            Listele();
        }
    }
}
