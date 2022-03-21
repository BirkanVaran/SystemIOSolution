using System;
using System.IO;

namespace SystemIOFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isTheFileExisits = false;
            isTheFileExisits = File.Exists("C:\\BirkanVaran\\Merhaba.txt");
            if (!isTheFileExisits)
            {
                CreateFile("C:\\BirkanVaran\\Merhaba.txt");
            }
            else
            {
                Console.WriteLine("Dosya zaten mevcut.");
            }

            Console.WriteLine("Dosya içine yazılacak metni giriniz:");
            string metin = Console.ReadLine();

            FileAppendTheText("C:\\BirkanVaran\\Merhaba.txt", metin);
            Console.WriteLine("Dosya düzenlendi.");

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Dosyanız kopyalanıyor...");
            FileCopy("C:\\BirkanVaran\\Merhaba.txt", "C:\\BirkanVaran\\MerhabaVopy.txt");
            Console.WriteLine();
            Console.WriteLine("Dosyanızı taşıyoruz...");
            MoveFile("C:\\BirkanVaran\\Merhaba.txt", "C:\\BirkanVaran2\\Merhaba.txt");
            Console.WriteLine();

            Console.WriteLine("Merhaba.txt metin belgesini silmek ister misiniz? (E/H)");

            ConsoleKeyInfo cevap;

            cevap = Console.ReadKey();

            if (cevap.Key==ConsoleKey.E)
            {
                DeleteTheFile("C:\\BirkanVaran\\Merhaba.txt");
                Console.WriteLine("Dosya silme işlemi başarılı oldu.");
            }
            else if (cevap.Key==ConsoleKey.H)
            {
                Console.WriteLine("Dosya silme işlemi yapılmadı.");
            }
            else
            {
                Console.WriteLine("Soruya geçerli bir cevap vermediniz.");
            }

            Console.ReadKey();

        }
        private static void CreateFile(string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
        }

        private static void FileAppendTheText(string path, string text)
        {
            File.AppendAllText(path, text);
        }

        private static void DeleteTheFile(string path)
        {
            File.Delete(path);
        }
        private static void FileCopy(string sourceFile, string destFile)
        {
            //  File.Copy(sourceFile, destFile);

            // Will overwrite if the destination file already exists.
            //     File.Copy(sourceFile, destFile, true);
            // eğer overWrite parametresi true olarak verilirse var olan bir dosyaya kopyalama yapabilir.

            //Eğer overWrite parametresi false verilirse kendisinin oluşturması için bir dosya ismi destFile'a verilir.
            File.Copy(sourceFile, destFile, false);
        }

        private static void MoveFile (string sourceFile, string destFile)
        {
            File.Move(sourceFile, destFile);
        }
    }
}
