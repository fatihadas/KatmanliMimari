using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KatmanliMimari.Models;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KatmanliMimari.Providers
{
    class Helper
    {
        public List<Musteriler> TakeData()
        {
            List<Musteriler> musteriler = new List<Musteriler>();
            Veri veritabani = new Veri();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("SELECT MusteriID,SirketAdi,MusteriAdi," +
                "MusteriUnvani,Adres,Sehir,Bolge,PostaKodu,Ulke,Telefon,Faks from Musteriler");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (dataReader.Read())
            {
                Musteriler musteri = new Musteriler(
                    dataReader["MusteriID"].ToString(),
                    dataReader["SirketAdi"].ToString(),
                    dataReader["MusteriAdi"].ToString(),
                    dataReader["MusteriUnvani"].ToString(),
                    dataReader["Adres"].ToString(),
                    dataReader["Sehir"].ToString(),
                    dataReader["Bolge"].ToString(),
                    dataReader["PostaKodu"].ToString(),
                    dataReader["Ulke"].ToString(),
                    dataReader["Telefon"].ToString(),
                    dataReader["Faks"].ToString());
                musteriler.Add(musteri);
            }

            connection.Close();
            return musteriler;

        }
    }
}
