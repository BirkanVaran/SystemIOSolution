﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWindowsFormApp
{
    public class VeriIslemleri
    {
        public List<Personel> PersonelleriGetir()
        {
            List<Personel> personelListesi = new List<Personel>();
            try
            {
                for (int i = 0; i <100; i++)
                {
                    Personel p = new Personel()
                    {
                        Isım = FakeData.NameData.GetFirstName(),
                        Soyisim = FakeData.NameData.GetSurname(),
                        Email = FakeData.NetworkData.GetEmail(),
                        Firma = FakeData.NameData.GetCompanyName(),
                        Ulke = FakeData.PlaceData.GetCountry(),
                    };
                    personelListesi.Add(p);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return personelListesi;
        }

        public bool PersoneliKaydet(string dosyaYolu,  out string kayitOlduguYol , Personel p)

        {

            bool sonuc = false;
            try
            {
                DirectoryInfo ulkeBilgisi = null;
                if (Directory.Exists(dosyaYolu + "\\" + p.Ulke))
                {
                    ulkeBilgisi = new DirectoryInfo(dosyaYolu + "\\" + p.Ulke);
                }
                else
                {
                    ulkeBilgisi = Directory.CreateDirectory(dosyaYolu + "\\" + p.Ulke);
                }
                FileStream fs = File.Create(ulkeBilgisi.FullName + "\\" + p.Isım + " " + p.Soyisim + ".txt");
                kayitOlduguYol = ulkeBilgisi.FullName + "\\" + p.Isım + " " + p.Soyisim + ".txt";

                // Buraya döneceğiz.
                byte[] personelBilgi = new UTF8Encoding(true).GetBytes(p.PersonelDetayBilgisiGetir());
                fs.Write(personelBilgi, 0, personelBilgi.Length);
                fs.Close();
                sonuc = true;
                
            }
           
            catch (Exception ex)
            {

                throw ex;
            }
            return sonuc;       
        }
    }
}
