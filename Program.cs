

using ConstructorPratic;

Bebek bebek = new Bebek("Efe", "Bilge"); // Parametreli constructor ile bir Bebek nesnesi oluşturuluyor

Console.WriteLine("Bebek Bilgileri:");
bebek.Yazdir(); // Yazdir metodu ile özellikler ekrana yazdırılıyor

Console.WriteLine("-----------");
Bebek bebek2 = new Bebek(); // Default constructor ile bir Bebek nesnesi oluşturuluyor

// Ad ve Soyad özellikleri sonradan atanıyor
bebek2.Ad = "ali";
bebek2.Soyad= "uzun";

Console.WriteLine("Bebek Bilgileri:");
bebek2.Yazdir(); // Yazdir metodu ile özellikler ekrana yazdırılıyor
