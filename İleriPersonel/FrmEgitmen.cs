using İleriPersonel.Context;
using İleriPersonel.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İleriPersonel
{
    public partial class FrmEgitmen : Form
    {
        public FrmEgitmen()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        Egitmen secEgitmen;

        private void FrmEgitmen_Load(object sender, EventArgs e)
        {
            Doldur();
            DoldurCmBoxes();
            DoldurCmIlce(1);
        }

        private void DoldurCmIlce(int v)
        {

            cmIlce.DataSource = db.Set<Ilce>().Select(x => new
            {
                Ad = x.Ad,
                Id = x.Id,
                SehirId = x.SehirId


            }).Where(x => x.SehirId == v).ToList();

            cmIlce.DisplayMember = "Ad";
            cmIlce.ValueMember = "Id";
        }

        private void DoldurCmBoxes()
        {
            cmEgitim.DataSource = db.Set<Egitim>().Select(x => new
            {
                Ad = x.Ad,
                Id = x.Id,


            }).ToList();

            cmEgitim.DisplayMember = "Ad";
            cmEgitim.ValueMember = "Id";

            cmSehir.DataSource = db.Set<Sehir>().Select(x => new
            {
                Ad = x.Ad,
                Id = x.Id,


            }).ToList();

            cmSehir.DisplayMember = "Ad";
            cmSehir.ValueMember = "Id";


        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Egitmen>().Select(x => new InsanDTO
            {
                Id = x.Id,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Ilce = x.Ilce.Ad,
                Sehir = x.Ilce.Sehir.Ad


            }).ToList();
        }

        private void cmSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenSehirId = 0;

            try
            {
                secilenSehirId = (int)cmSehir.SelectedValue;
                DoldurCmIlce(secilenSehirId);

            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secEgitmen = db.Set<Egitmen>().Find(secId);
            txAd.Text = secEgitmen.Ad;
            txSoyad.Text = secEgitmen.Soyad;
            txMaas.Text = Convert.ToString(secEgitmen.Maas);
            cmIlce.SelectedValue = secEgitmen.IlceId;
            cmEgitim.SelectedValue = secEgitmen.EgitimId;
            cmSehir.SelectedValue = secEgitmen.Ilce.SehirId;
            lsAdres.DataSource = secEgitmen.AdresAl();          
            txUnvan.Text = secEgitmen.Unvan;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Egitmen egitmen = new Egitmen ();
            egitmen.Ad = txAd.Text;
            egitmen.Maas = Convert.ToDecimal(txMaas.Text);
            egitmen.Soyad = txSoyad.Text;
            egitmen.IlceId = (int)cmIlce.SelectedValue;
            egitmen.EgitimId = (int)cmEgitim.SelectedValue;
            egitmen.Unvan = txUnvan.Text;
            db.Set<Egitmen>().Add(egitmen);
            db.SaveChanges();
            Doldur();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            secEgitmen.Ad = txAd.Text;
            secEgitmen.Maas = Convert.ToDecimal(txMaas.Text);
            secEgitmen.Soyad = txSoyad.Text;
            secEgitmen.IlceId = (int)cmIlce.SelectedValue;
            secEgitmen.EgitimId = (int)cmEgitim.SelectedValue;
            db.SaveChanges();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Egitmen>().Remove(secEgitmen);
            db.SaveChanges();
            Doldur();
        }
    }
}
