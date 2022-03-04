
namespace İleriPersonel
{
    partial class FrmEgitmen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txAd = new System.Windows.Forms.TextBox();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.txMaas = new System.Windows.Forms.TextBox();
            this.txUnvan = new System.Windows.Forms.TextBox();
            this.lsAdres = new System.Windows.Forms.ListBox();
            this.cmSehir = new System.Windows.Forms.ComboBox();
            this.cmIlce = new System.Windows.Forms.ComboBox();
            this.cmEgitim = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "İlçe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Eğitim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Maaş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ünvan";
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(542, 19);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(121, 20);
            this.txAd.TabIndex = 8;
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(542, 45);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(121, 20);
            this.txSoyad.TabIndex = 9;
            // 
            // txMaas
            // 
            this.txMaas.Location = new System.Drawing.Point(542, 161);
            this.txMaas.Name = "txMaas";
            this.txMaas.Size = new System.Drawing.Size(119, 20);
            this.txMaas.TabIndex = 13;
            // 
            // txUnvan
            // 
            this.txUnvan.Location = new System.Drawing.Point(542, 187);
            this.txUnvan.Name = "txUnvan";
            this.txUnvan.Size = new System.Drawing.Size(119, 20);
            this.txUnvan.TabIndex = 14;
            // 
            // lsAdres
            // 
            this.lsAdres.FormattingEnabled = true;
            this.lsAdres.Location = new System.Drawing.Point(541, 213);
            this.lsAdres.Name = "lsAdres";
            this.lsAdres.Size = new System.Drawing.Size(120, 95);
            this.lsAdres.TabIndex = 15;
            // 
            // cmSehir
            // 
            this.cmSehir.FormattingEnabled = true;
            this.cmSehir.Location = new System.Drawing.Point(541, 74);
            this.cmSehir.Name = "cmSehir";
            this.cmSehir.Size = new System.Drawing.Size(121, 21);
            this.cmSehir.TabIndex = 16;
            this.cmSehir.SelectedIndexChanged += new System.EventHandler(this.cmSehir_SelectedIndexChanged);
            // 
            // cmIlce
            // 
            this.cmIlce.FormattingEnabled = true;
            this.cmIlce.Location = new System.Drawing.Point(541, 106);
            this.cmIlce.Name = "cmIlce";
            this.cmIlce.Size = new System.Drawing.Size(121, 21);
            this.cmIlce.TabIndex = 17;
            // 
            // cmEgitim
            // 
            this.cmEgitim.FormattingEnabled = true;
            this.cmEgitim.Location = new System.Drawing.Point(542, 133);
            this.cmEgitim.Name = "cmEgitim";
            this.cmEgitim.Size = new System.Drawing.Size(121, 21);
            this.cmEgitim.TabIndex = 18;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(464, 326);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.Location = new System.Drawing.Point(555, 326);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(75, 23);
            this.btnGuncel.TabIndex = 20;
            this.btnGuncel.Text = "Güncelle";
            this.btnGuncel.UseVisualStyleBackColor = true;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(647, 326);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmEgitmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmEgitim);
            this.Controls.Add(this.cmIlce);
            this.Controls.Add(this.cmSehir);
            this.Controls.Add(this.lsAdres);
            this.Controls.Add(this.txUnvan);
            this.Controls.Add(this.txMaas);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEgitmen";
            this.Text = "FrmEgitmen";
            this.Load += new System.EventHandler(this.FrmEgitmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.TextBox txMaas;
        private System.Windows.Forms.TextBox txUnvan;
        private System.Windows.Forms.ListBox lsAdres;
        private System.Windows.Forms.ComboBox cmSehir;
        private System.Windows.Forms.ComboBox cmIlce;
        private System.Windows.Forms.ComboBox cmEgitim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.Button btnSil;
    }
}