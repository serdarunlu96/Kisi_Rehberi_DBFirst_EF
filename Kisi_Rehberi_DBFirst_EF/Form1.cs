using Kisi_Rehberi_DBFirst_EF.Models;

namespace Kisi_Rehberi_DBFirst_EF
{
    public partial class Form1 : Form
    {
        KisiRehberiDBContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new KisiRehberiDBContext();

            Listele();
        }

        private void Listele()
        {
            dgvContact.DataSource = null;
            dgvContact.DataSource = _db.Concats.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_db.Concats.Find(Convert.ToInt32(txtId.Text)) != null)
            {
                MessageBox.Show("Eklenmeye calýsýlan ID ye ait kisi Rehberde mevcuttur, lutfen baska ID giriniz!");
                return;
            }

            Kisi_Rehberi_DBFirst_EF.Models.Concat yeniKisi = new Kisi_Rehberi_DBFirst_EF.Models.Concat();
            yeniKisi.Id = Convert.ToInt32(txtId.Text);
            yeniKisi.FirstName = txtAd.Text;
            yeniKisi.LastName = txtSoyad.Text;
            yeniKisi.PhoneNumber = txtTelefon.Text;

            _db.Concats.Add(yeniKisi);

            _db.SaveChanges();

            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Kisi_Rehberi_DBFirst_EF.Models.Concat guncelleKisi = _db.Concats.FirstOrDefault(r => r.Id == Convert.ToInt32(txtId.Text))!;

                guncelleKisi.FirstName = txtAd.Text;
                guncelleKisi.LastName = txtSoyad.Text;
                guncelleKisi.PhoneNumber = txtTelefon.Text;

                _db.SaveChanges();

                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string tanim;

            Kisi_Rehberi_DBFirst_EF.Models.Concat silinecekKisi = _db.Concats.FirstOrDefault(r => r.Id == Convert.ToInt32(txtId.Text))!;

            if (silinecekKisi == null)
            {
                MessageBox.Show("Yazýlan Id ye ait Kisi bulunmamaktadýr.");
                return;
            }
            tanim=silinecekKisi.FirstName;

            _db.Concats.Remove(silinecekKisi);

            _db.SaveChanges();

            Listele();

            MessageBox.Show(txtId.Text + " ID lý kisi " + tanim + " isimli kisi rehberden silindi!");
        }
    }
}