using System;
using System.IO;

namespace DirectoryConsoleOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            // CC Klasörü içine kendi adınızla bir kalsör oluşturmanız isteniyor.
            // Kullanıcıya 1) Klasör Sil 2) Klasörü taşı gibi menü sunmanız isteniyor.
            // Silme işlemi seçilirse Emin misiniz? E/H sormalı. Verilen yanıta göre silme işlemi yapılmalı.

            string myPath = @"C:\BirkanVaran";

            Console.WriteLine("Hangi işlemi yapmak istersiniz?");
            Console.WriteLine("Klasör oluşturma --->1");
            Console.WriteLine("Klasör silme --->2");
            Console.WriteLine("Klasör taşıma --->3");

            ConsoleKeyInfo secim;
            secim = Console.ReadKey();
            switch (secim.Key)
            {
                case ConsoleKey.D1:
                    if (KlasordenVarMi(myPath))
                    {
                        Console.WriteLine(" Klasör zaten mevcut.");
                    }
                    else
                    {
                        YeniKlasor(myPath);
                        Console.WriteLine("Klasör oluşturuldu.");
                    }
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine();
                    KlasorSil(myPath);
                    break;
                case ConsoleKey.D3:
                    if (KlasordenVarMi(myPath))
                    {
                        break;
                    }
                    else
                    {
                        YeniKlasor(myPath);
                        Console.WriteLine("Klasör oluşturuldu.");
                    }

                    KlasoruTasi(myPath, @"C:\BirkanVaran_2");
                    Console.WriteLine("Klasör kaynak yoldan, hedef yola taşındı.");
                    break;

                default:
                    Console.WriteLine("Seçim hatalı.");
                    break;
            }

            //if (KlasordenVarMi(myPath))
            //{
            //    Console.WriteLine(" Klasör zaten mevcut.");
            //}
            //else
            //{
            //    YeniKlasor(myPath);
            //    Console.WriteLine("Klasör oluşturuldu.");
            //}

            

            //YeniKlasor(myPath);
            //Console.WriteLine("Klasör yeniden oluşturuldu.");
            


            Console.Read();
            Console.WriteLine("Hello World!");
        }
            


            
        

        private static void YeniKlasor(string hedefYol)
        {
            DirectoryInfo di = Directory.CreateDirectory(hedefYol);
        }

        private static bool KlasordenVarMi(string dosyaYolu)
        {
            bool sonuc = false;

            sonuc = Directory.Exists(dosyaYolu);

            return sonuc;
        }

        private static void KlasoruTasi(string kaynakYol, string hedefyol)
        {
            Directory.Move(kaynakYol, hedefyol);
        }

        private static void KlasorSil(string hedefyol)
        {
            Console.WriteLine("Silmek istediğinize emin misiniz?");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.E)
            {
                Directory.Delete(hedefyol);
                Console.WriteLine("Klasör silindi.");
            }
            else
            {
                Console.WriteLine("Silme işlemi yapılmadı.");
            }
            
        }

    }
}
