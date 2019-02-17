using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Models
{
    public class Musteriler
    {
        public string MusteriID { get; set; }
        public string SirketAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriUnvani { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }

        public Musteriler(string musteriID, string sirketAdi, string musteriAdi, string musteriunvani, string adres,
            string sehir, string bolge, string postakodu, string ulke, string telefon, string faks)
        {
            this.MusteriID = musteriID;
            this.SirketAdi = sirketAdi;
            this.MusteriAdi = musteriAdi;
            this.MusteriUnvani = musteriunvani;
            this.Adres = adres;
            this.Sehir = sehir;
            this.Bolge = bolge;
            this.PostaKodu = postakodu;
            this.Ulke = ulke;
            this.Telefon = telefon;
            this.Faks = faks;
        }


    }

}
