using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunkar_Sofrasi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

       

        private void GirisForm_Load(object sender, EventArgs e)
        {
            cPersonel Personel = new cPersonel();
            Personel.PersonelGetByInformation(PersonelCB);
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            cVeriTabani VeriTabani = new cVeriTabani();
            cPersonel Personel = new cPersonel();
            bool result = Personel.PersonelEntryControl(TxtSifre.Text, cVeriTabani._PersonelId);

            if (result)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cVeriTabani._PersonelId;
                ch.Islem = "Giriş Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);

                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
            }

            else
            {
                lblerror.Visible = true;
            }
        }

        private void PersonelCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonel Personel = (cPersonel)PersonelCB.SelectedItem; // ✅ Doğrudan nesne olarak alınıyor
            cVeriTabani._PersonelId = Personel.PersonelId;
            cVeriTabani._GorevId = Personel.PersonelGorevId;
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Kapatmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
