namespace EczaneOtomasyonu
{
    public partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenceEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtBarkodNo = new System.Windows.Forms.MaskedTextBox();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.ilaçlarToolStripMenuItem,
            this.güvenceToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKaydıToolStripMenuItem,
            this.hastalarıListeleToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.hastaGüncelleToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // hastaKaydıToolStripMenuItem
            // 
            this.hastaKaydıToolStripMenuItem.Name = "hastaKaydıToolStripMenuItem";
            this.hastaKaydıToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.hastaKaydıToolStripMenuItem.Text = "Hasta Kaydı";
            this.hastaKaydıToolStripMenuItem.Click += new System.EventHandler(this.hastaKaydıToolStripMenuItem_Click);
            // 
            // hastalarıListeleToolStripMenuItem
            // 
            this.hastalarıListeleToolStripMenuItem.Name = "hastalarıListeleToolStripMenuItem";
            this.hastalarıListeleToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.hastalarıListeleToolStripMenuItem.Text = "Hastaları Listele";
            this.hastalarıListeleToolStripMenuItem.Click += new System.EventHandler(this.hastalarıListeleToolStripMenuItem_Click);
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.hastaToolStripMenuItem.Text = "Hasta Sil";
            this.hastaToolStripMenuItem.Click += new System.EventHandler(this.hastaToolStripMenuItem_Click);
            // 
            // hastaGüncelleToolStripMenuItem
            // 
            this.hastaGüncelleToolStripMenuItem.Name = "hastaGüncelleToolStripMenuItem";
            this.hastaGüncelleToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.hastaGüncelleToolStripMenuItem.Text = "Hasta Güncelle";
            this.hastaGüncelleToolStripMenuItem.Click += new System.EventHandler(this.hastaGüncelleToolStripMenuItem_Click);
            // 
            // ilaçlarToolStripMenuItem
            // 
            this.ilaçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçKaydıToolStripMenuItem,
            this.ilaçlarıListeleToolStripMenuItem,
            this.ilaçSilToolStripMenuItem,
            this.ilaçGüncelleToolStripMenuItem});
            this.ilaçlarToolStripMenuItem.Name = "ilaçlarToolStripMenuItem";
            this.ilaçlarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ilaçlarToolStripMenuItem.Text = "İlaçlar";
            // 
            // ilaçKaydıToolStripMenuItem
            // 
            this.ilaçKaydıToolStripMenuItem.Name = "ilaçKaydıToolStripMenuItem";
            this.ilaçKaydıToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilaçKaydıToolStripMenuItem.Text = "İlaç Kaydı";
            this.ilaçKaydıToolStripMenuItem.Click += new System.EventHandler(this.ilaçKaydıToolStripMenuItem_Click_1);
            // 
            // ilaçlarıListeleToolStripMenuItem
            // 
            this.ilaçlarıListeleToolStripMenuItem.Name = "ilaçlarıListeleToolStripMenuItem";
            this.ilaçlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilaçlarıListeleToolStripMenuItem.Text = "İlaçları Listele";
            this.ilaçlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.ilaçlarıListeleToolStripMenuItem_Click);
            // 
            // ilaçSilToolStripMenuItem
            // 
            this.ilaçSilToolStripMenuItem.Name = "ilaçSilToolStripMenuItem";
            this.ilaçSilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilaçSilToolStripMenuItem.Text = "İlaç Sil";
            this.ilaçSilToolStripMenuItem.Click += new System.EventHandler(this.ilaçSilToolStripMenuItem_Click);
            // 
            // ilaçGüncelleToolStripMenuItem
            // 
            this.ilaçGüncelleToolStripMenuItem.Name = "ilaçGüncelleToolStripMenuItem";
            this.ilaçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilaçGüncelleToolStripMenuItem.Text = "İlaç Güncelle";
            this.ilaçGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ilaçGüncelleToolStripMenuItem_Click);
            // 
            // güvenceToolStripMenuItem
            // 
            this.güvenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güvenceEkleToolStripMenuItem});
            this.güvenceToolStripMenuItem.Name = "güvenceToolStripMenuItem";
            this.güvenceToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.güvenceToolStripMenuItem.Text = "Güvence";
            // 
            // güvenceEkleToolStripMenuItem
            // 
            this.güvenceEkleToolStripMenuItem.Name = "güvenceEkleToolStripMenuItem";
            this.güvenceEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.güvenceEkleToolStripMenuItem.Text = "Güvence Ekle";
            this.güvenceEkleToolStripMenuItem.Click += new System.EventHandler(this.güvenceEkleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 306);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "HastaNo(TC.No) : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod No : ";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(149, 79);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(75, 22);
            this.txtTcNo.TabIndex = 5;
            this.txtTcNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(345, 79);
            this.txtBarkodNo.Mask = "00000";
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(75, 22);
            this.txtBarkodNo.TabIndex = 6;
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(504, 79);
            this.numAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(75, 22);
            this.numAdet.TabIndex = 7;
            this.numAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Satış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenceEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTcNo;
        private System.Windows.Forms.MaskedTextBox txtBarkodNo;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

