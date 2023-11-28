using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun2
{
         public class Oyuncu
    {
        public string Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Posta { get; set; }
        public double Puan { get; set; }
        public DateTime KayitTarih { get; set; }    
        public bool Aktif {  get; set; }
        public int defans { get; set; }

        //kurucu metot tanımlama.
        //Sadece kurucu metotlarda metod adı sınıf ile aynıdır
        //Kurucu metot tanımlandıktan sonra parameterler yazılır
        public Oyuncu(string id, string ad, string soyad, string posta, double puan,DateTime kayitTarih,bool aktifmi)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            Posta = posta;
            Puan = puan;
            KayitTarih = kayitTarih;
            Aktif = aktifmi;
        }

        public string BilgiYaz()
        {
            return "ID :\t\t" + Id  + "\nAd:\t\t" + Ad + "\nSoyad :\t\t" + Soyad+ "\nKayıt Tarihi:\t" + KayitTarih;
        }
        public void DefansArttır()
        {
            Random random = new Random();
            defans=random.Next(10,20);
            
        }

    }
}
