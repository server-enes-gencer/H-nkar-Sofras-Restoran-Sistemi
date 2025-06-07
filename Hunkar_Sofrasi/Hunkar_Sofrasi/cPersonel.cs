using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunkar_Sofrasi
{
    internal class cPersonel
    {
        // Personel bilgileri
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private string _PersonelTc;
        private string _PersonelTel;
        private string _PersonelAdres;
        private bool _PersonelDurum;

        // Public erişilebilir özellikler
        public int PersonelId { get { return _PersonelId; } set { _PersonelId = value; } }
        public int PersonelGorevId { get { return _PersonelGorevId; } set { _PersonelGorevId = value; } }
        public string PersonelAd { get { return _PersonelAd; } set { _PersonelAd = value; } }
        public string PersonelSoyad { get { return _PersonelSoyad; } set { _PersonelSoyad = value; } }
        public string PersonelParola { get { return _PersonelParola; } set { _PersonelParola = value; } }
        public string PersonelKullaniciAdi { get { return _PersonelKullaniciAdi; } set { _PersonelKullaniciAdi = value; } }
        public string PersonelTc { get { return _PersonelTc; } set { _PersonelTc = value; } }
        public string PersonelTel { get { return _PersonelTel; } set { _PersonelTel = value; } }
        public string PersonelAdres { get { return _PersonelAdres; } set { _PersonelAdres = value; } }
        public bool PersonelDurum { get { return _PersonelDurum; } set { _PersonelDurum = value; } }

        // Veritabanı bağlantı nesnesi
        private cVeriTabani VeriTabani = new cVeriTabani();

        // Personel giriş kontrolü
        public bool PersonelEntryControl(string password, int userId)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(VeriTabani.conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Personel WHERE ID=@Id AND Parola=@password", con))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userId;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        result = Convert.ToBoolean(cmd.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Hata oluştu: " + ex.Message);
                    }
                }
            }
            return result;
        }

        // Personel bilgilerini getir
        public void PersonelGetByInformation(ComboBox cb)
        {
            cb.Items.Clear();
            using (SqlConnection con = new SqlConnection(VeriTabani.conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Personel", con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cPersonel Personel = new cPersonel
                        {
                            PersonelId = Convert.ToInt32(dr["Id"]),
                            PersonelGorevId = Convert.ToInt32(dr["Gorev_Id"]),
                            PersonelAd = dr["Personel_Ad"].ToString(),
                            PersonelSoyad = dr["Personel_Soyad"].ToString(),
                            PersonelKullaniciAdi = dr["Kullanici_Adi"].ToString(), // ✅ Kullanıcı Adı çekiliyor
                            PersonelParola = dr["Parola"].ToString(),
                            PersonelTc = dr["Personel_Tc"].ToString(),
                            PersonelTel = dr["Personel_Tel"].ToString(),
                            PersonelAdres = dr["Personel_Adres"].ToString(),
                            PersonelDurum = Convert.ToBoolean(dr["Durum"])
                        };

                        cb.Items.Add(Personel); // ✅ Nesne olarak ekleniyor
                    }

                    dr.Close();
                }
                con.Close();
            }
        }

        // ComboBox için doğru gösterim
        public override string ToString()
        {
            return PersonelKullaniciAdi; 
        }
    }
}
