using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class ProductDal
    {
        // Veri Tabanı Bilgileri
        SqlConnection _connection = new SqlConnection("Initial Catalog=*******;Data Source=*******;Integrated Security=SSPI;");

        #region List Yönetimi Kullanımı
        public List<Product> GetAll()
        {
            ConnectionControl(); // Bağlantı kapalı ise acacak metod
            SqlCommand command = new SqlCommand("Select * from PERSONEL", _connection); // Sql Sorgusu

            SqlDataReader reader = command.ExecuteReader(); // Komutu çalıştırır.
            List<Product> products = new List<Product>();

            while (reader.Read()) // Dataları tek tek okuyor.
            {
                Product product = new Product
                {
                    // Veritabanındaki Id'ler Aktarıyor
                    PERSONEL_ID = Convert.ToInt32(reader["PERSONEL_ID"]),
                    PERSONEL_TC_NO = reader["PERSONEL_TC_NO"].ToString(),
                    PERSONEL_AD = reader["PERSONEL_AD"].ToString(),
                    PERSONEL_SOYAD = reader["PERSONEL_SOYAD"].ToString(),
                    PERSONEL_DOGUM_TARIH = (DateTime)reader["PERSONEL_DOGUM_TARIH"],
                    PERSONEL_CINSIYET = reader["PERSONEL_CINSIYET"].ToString(),
                    PERSONEL_UYRUK = reader["PERSONEL_UYRUK"].ToString(),
                    PERSONEL_TELEFON = reader["PERSONEL_TELEFON"].ToString(),
                    PERSONEL_GOREV = reader["PERSONEL_GOREV"].ToString(),
                    PERSONEL_EMAIL = reader["PERSONEL_EMAIL"].ToString(),
                    PERSONEL_DURUM = reader["PERSONEL_DURUM"].ToString(),

                };
                products.Add(product); // listeye Ekleniyor.
            }
           

            reader.Close();
            _connection.Close();
            return products; // listeye döner.
        }
        #endregion

        #region Data Table Kullanımı
        //Data Table Göre İşlem yapılmıştır.
        public DataTable GetAll2()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from PERSONEL", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }
        #endregion

        #region Bağlantı Kontrol 
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
        }
        #endregion
        
        #region Sql Veri Ekleme
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into PERSONEL values(@PERSONEL_TC_NO,@PERSONEL_AD,@PERSONEL_SOYAD,@PERSONEL_DOGUM_TARIH,@PERSONEL_CINSIYET,@PERSONEL_UYRUK,@PERSONEL_TELEFON,@PERSONEL_GOREV,@PERSONEL_EMAIL,@PERSONEL_DURUM)", _connection);
            command.Parameters.AddWithValue("@PERSONEL_AD", product.PERSONEL_AD.ToUpper());
            command.Parameters.AddWithValue("@PERSONEL_SOYAD", product.PERSONEL_SOYAD.ToUpper());
            command.Parameters.AddWithValue("@PERSONEL_DOGUM_TARIH", product.PERSONEL_DOGUM_TARIH);
            command.Parameters.AddWithValue("@PERSONEL_TC_NO", product.PERSONEL_TC_NO);
            command.Parameters.AddWithValue("@PERSONEL_CINSIYET", product.PERSONEL_CINSIYET);
            command.Parameters.AddWithValue("@PERSONEL_UYRUK ", product.PERSONEL_UYRUK.ToUpper());
            command.Parameters.AddWithValue("@PERSONEL_TELEFON ", product.PERSONEL_TELEFON);
            command.Parameters.AddWithValue("@PERSONEL_GOREV ", product.PERSONEL_GOREV);
            command.Parameters.AddWithValue("@PERSONEL_EMAIL", product.PERSONEL_EMAIL);
            command.Parameters.AddWithValue("@PERSONEL_DURUM", product.PERSONEL_DURUM);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        #endregion

        #region Sql Veri Güncelleme
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update PERSONEL set PERSONEL_AD=@PERSONEL_AD, PERSONEL_SOYAD=@PERSONEL_SOYAD, PERSONEL_DOGUM_TARIH=@PERSONEL_DOGUM_TARIH,PERSONEL_TC_NO=@PERSONEL_TC_NO, PERSONEL_CINSIYET=@PERSONEL_CINSIYET, PERSONEL_UYRUK=@PERSONEL_UYRUK,PERSONEL_TELEFON=@PERSONEL_TELEFON, PERSONEL_GOREV=@PERSONEL_GOREV, PERSONEL_EMAIL=@PERSONEL_EMAIL, PERSONEL_DURUM=@PERSONEL_DURUM where PERSONEL_ID=@PERSONEL_ID", _connection);
            command.Parameters.AddWithValue("@PERSONEL_AD", product.PERSONEL_AD.ToUpper());
            command.Parameters.AddWithValue("@PERSONEL_SOYAD", product.PERSONEL_SOYAD.ToUpper());
            command.Parameters.AddWithValue("@PERSONEL_DOGUM_TARIH", product.PERSONEL_DOGUM_TARIH);
            command.Parameters.AddWithValue("@PERSONEL_TC_NO", product.PERSONEL_TC_NO);
            command.Parameters.AddWithValue("@PERSONEL_CINSIYET", product.PERSONEL_CINSIYET);
            command.Parameters.AddWithValue("@PERSONEL_UYRUK ", product.PERSONEL_UYRUK.ToUpper());
            command.Parameters.AddWithValue("@PERSONEL_TELEFON ", product.PERSONEL_TELEFON);
            command.Parameters.AddWithValue("@PERSONEL_GOREV ", product.PERSONEL_GOREV);
            command.Parameters.AddWithValue("@PERSONEL_EMAIL", product.PERSONEL_EMAIL);
            command.Parameters.AddWithValue("@PERSONEL_DURUM", product.PERSONEL_DURUM);
            command.Parameters.AddWithValue("@PERSONEL_ID", product.PERSONEL_ID);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        #endregion

        #region Sql Veri Silme
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from PERSONEL where PERSONEL_ID=@PERSONEL_ID", _connection);
            command.Parameters.AddWithValue("@PERSONEL_ID", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
    }
}
#endregion

