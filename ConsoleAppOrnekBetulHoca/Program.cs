using System;
using System.IO;
using System.Threading;

namespace ConsoleAppOrnekBetulHoca
{
    class Program
    {
        static void Main(string[] args)
        {
            // C klasörü içine kendi adınızla bir klasör oluşturmanız isteniyor.

            // Kullanıcıya Klasörü sil-- 1 Klasörü Taşı  --2 gibi menü sunmanız isteniyor
            // Kullanıcı hangi işlemi seçerse o işlem yapılacaktır
            // Silme işlemini seçerse Emin Misiniz? E/H sorusu sormanız ve verilecek cevaba göre silme işlemi yapmanız isteniyor.
            try
            {
                string myPath = "C:\\Betul103";
                if (KlasordenVarMi(myPath))
                {
                    Console.WriteLine("Klasörünüz sistemde mevcuttur...");
                }
                else
                {
                    YeniKlasorOlustur(myPath);
                }

            Baslangic:

                Console.WriteLine("*******İŞLEM MENÜSÜ*********");
                Console.WriteLine("Klasör Silmek için ---> 1");
                Console.WriteLine("Klasör Taşımak için--->2");
                int islem = 0;
                ConsoleKeyInfo secim;
                islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 1)
                {
                SilSorusu:

                    Console.WriteLine($"{myPath} directory'yi silmek istediğinize emin misiniz? E/H   : ");
                    secim = Console.ReadKey();
                    switch (secim.Key)
                    {
                        case ConsoleKey.E:
                            KlasoruSil(myPath);
                            Console.WriteLine("Silindi...");
                            break;

                        case ConsoleKey.H:
                            Console.WriteLine("\n Silinmedi... ");

                            goto Baslangic;

                        default:
                            Console.WriteLine("Lütfen size sorulan soruya uygun cevap veriniz...");
                            goto SilSorusu;

                    }
                }
                else if (islem == 2)
                {
                    string yeniHedef;
                    Console.WriteLine("Hedef klasör isim veriniz :");
                    yeniHedef = Console.ReadLine();
                    string yeniYol = @"C:\" + yeniHedef;
                    KlasoruTasi(myPath, yeniYol);

                }
                else
                {
                    Console.WriteLine("Geçerli bir işlem tercihi yapmadınız!!!");
                    Thread.Sleep(300);
                    Console.Clear();
                    goto Baslangic;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("HATA: Beklenmedik bir hata oluştu!" + ex.Message);
            }



            Console.ReadKey();
        }

        private static void YeniKlasorOlustur(string dosyaYolu)
        {
            DirectoryInfo di = Directory.CreateDirectory(dosyaYolu);
        }

        private static bool KlasordenVarMi(string dosyaYolu)
        {
            bool sonuc = false;

            sonuc = Directory.Exists(dosyaYolu);
            return sonuc;

        }

        private static void KlasoruSil(string dosyaYolu)
        {
            Directory.Delete(dosyaYolu);

        }

        private static void KlasoruTasi(string kaynakYol, string HedefYol)
        {
            //Directory.Move(source, dest)
            //NOT: dest yolunu metot içeride kendisi oluşturuyor.
            Directory.Move(kaynakYol, HedefYol);
            Console.WriteLine($"kaynak :{kaynakYol}, {HedefYol} hedefine taşındı...");
        }
    }
}

