using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Models
{
    class Veri
    {
        // Bağlantı adresimizi yazıp, bağlantıyı açıyoruz
        public SqlConnection OpenConnection()
        {
            SqlConnection baglanti = new SqlConnection("Server=.;database=KatmanliMimari;trusted_connection=true");
            baglanti.Open();
            return baglanti;
        }
        // Her sorgu oluşturduğumuzda buradan yararlanacağız.
        public SqlCommand CreateConnection(string sorgu)
        {
            SqlCommand sqlCommand = new SqlCommand(sorgu, OpenConnection());
            return sqlCommand;
        }

    }
}
