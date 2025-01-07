using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPratic
{
    public class Bebek
    { 
        // bebek sınıfının fieldları
        private string _ad;
        private string _soyad;
        private DateTime _dogumTarihi;

        public string Ad // _ad özelliğine diğer sınıflardan erişim sağlamak ve değer atamak için bu property kullanılır.
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Soyad // _soyad özelliğine diğer sınıflardan erişim sağlamak ve değer atamak için bu property kullanılır.
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public DateTime DogumTarihi // _doğumtarihi özelliğine diğer sınıflardan erişim sağlamak ve değer atamak için bu property kullanılır.
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }
        public Bebek()  // Default Constructor (Parametre almayan yapıcı metot)
       
        {
            _dogumTarihi = DateTime.Now;   // Doğum tarihi olarak o anki tarih atanır 
            Console.WriteLine("Ingaaa");

        }

        // Parametreli Constructor
        public Bebek(string ad, string soyad)  // Ad ve Soyad parametre olarak alınır ve alanlara atanır
        {
            _ad = ad;
            _soyad = soyad;
            _dogumTarihi = DateTime.Now;   // Doğum tarihi olarak o anki tarih atanır 
            Console.WriteLine("Ingaaa");
        }

        public void Yazdir()  // Yazdir metodu
        {
            Console.WriteLine($"Ad: {_ad}");
            Console.WriteLine($"Soyad: {_soyad}");
            Console.WriteLine($"Doğum Tarihi: {_dogumTarihi}");
        }
    }
}
