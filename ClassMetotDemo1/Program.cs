using ClassMetotDemo;
using System.Text;

Musteri musteri1 = new Musteri();
musteri1.MusteriAdi = "Doğukan";
musteri1.MusteriSoy = "Çelik";
musteri1.MusteriId = 7456545;
musteri1.MusteriKimlik = 44454624578;

Musteri musteri2 = new Musteri();
musteri2.MusteriAdi = "Furkan";
musteri2.MusteriSoy = "Özer";
musteri2.MusteriId = 7451245;
musteri2.MusteriKimlik = 44410624578;

Musteri musteri3 = new Musteri();
musteri3.MusteriAdi = "Arda";
musteri3.MusteriSoy = "Karaman";
musteri3.MusteriId = 1256545;
musteri3.MusteriKimlik = 55454624518;

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

foreach (var Musteri in musteriler)
{
    Console.WriteLine(Musteri.MusteriAdi + "-" + Musteri.MusteriSoy + "-" + Musteri.MusteriId + "-" + Musteri.MusteriKimlik);
}
MusteriManager musteriManager = new MusteriManager();


musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Sil(musteri1);
musteriManager.Sil(musteri2);
musteriManager.Sil(musteri3);