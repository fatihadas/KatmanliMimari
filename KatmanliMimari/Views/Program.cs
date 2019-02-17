using KatmanliMimari.Models;
using KatmanliMimari.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Musteriler> musteriListe = new List<Musteriler>();
            Helper helper = new Helper();

            musteriListe = helper.TakeData();
            int i = 0;
            foreach (Musteriler item in musteriListe)
            {
                Console.WriteLine((++i).ToString() + " - " + item.MusteriID + " " + item.SirketAdi + " " + item.MusteriAdi + " " +
                    item.MusteriUnvani + " " + item.Adres + " " + item.Sehir + " " + item.Bolge + " " + item.PostaKodu + " " +
                    item.Ulke + " " + item.Telefon + " " + item.Faks);
            }
            Console.ReadKey();

        }
    }
}
