using System;
using System.IO;

namespace SystemIODirectorySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPath = "C:\\Birkan_2";
            // If ile kontrol edelim:
            if (KlasordenVarMi(myPath))
            {
                Console.WriteLine($"{myPath} dosya yolu zaten oluşmuş.");
            }
            else // False dönmüş demektir. Directory oluşturmak için metot çağıralım:
            {
                YeniKlasorOlustur(myPath);
            }
            Console.WriteLine();

        
            //KlasoruSil(myPath);
            //Console.WriteLine($"{myPath} dosya yolu silindi.");


            //YeniKlasorOlustur(@"C:\Birkan");
            KlasoruTasi(myPath, @"C:\Birkan_3");
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
        public static void KlasoruTasi(string kaynakYol, string hedefYol)
        {
            // Dircetory.Move(source, destination)
            // NOT: Destination yolunu metot içeride kendi oluşturuyor.
            Directory.Move(kaynakYol, hedefYol);
            Console.WriteLine($"Kaynak: {kaynakYol}, {hedefYol} hedefine taşındı." );
        }


    }
}
