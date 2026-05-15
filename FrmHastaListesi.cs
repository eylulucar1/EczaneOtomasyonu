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
    public partial class FrmHastaListesi : Form
    {
        public FrmHastaListesi()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = EczaneDb.accdb");
        public void Listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Hastalar where durum = true", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource= tablo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmHastaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
