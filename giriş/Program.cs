using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace giriş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogruKullaniciAdi = "admin";
            string dogruSifre = "admin";

            Console.Write("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == dogruKullaniciAdi && sifre == dogruSifre)
            {
                Console.WriteLine("Giriş başarılı!");
                








                Console.WriteLine("sayı tahmin etme oyunu var oynamak istermisiniz (evet/hayır) ?");



                string cevap = Console.ReadLine();

                if (cevap == "evet")
                {


                    int hak = 10;
                    int tutulan = new Random().Next(1, 100);
                    int sayi;
                    int sayac = 0;


                    while (hak > 0)
                    {
                        sayac++;
                        Console.Write("sayı tahmin ediniz: ");
                        sayi = Convert.ToInt32(Console.ReadLine());

                        if (tutulan == sayi)
                        {
                            Console.WriteLine("Tebrikler doğru {0}. defada bildiniz..!", sayac);
                            break;
                        }
                        else
                        {
                            if (tutulan > sayi)
                            {
                                Console.WriteLine("Daha büyük bir sayı.");
                            }
                            else
                            {
                                Console.WriteLine("Daha küçük bir sayı.");
                            }
                        }
                        hak--;
                        if (hak == 0)
                        {
                            Console.WriteLine("oyun bitti");
                            break;

                        }



                    }

                }

                Console.WriteLine("Kelime Tahmin oyunu Oynamak ister misiniz? (evet/hayır): ");
                string cevapp = Console.ReadLine().ToLower();

                if (cevapp == "evet")
                {
                    OyunuBaslat();
                }
                else
                {
                    Console.WriteLine("Anladım. Oyun demo sürüm olup geliştirilme aşamasındadır.");
                    Console.WriteLine("Çıkışınız yapılıyor...");
                }

                Console.ReadLine();
            }
        }

        private static void OyunuBaslat()
        {
            string[] kelimeler = { "elma", "armut", "muz", "çilek", "portakal" };

            Random random = new Random();
            string tutulanKelime = kelimeler[random.Next(kelimeler.Length)];

            char[] tahminHarfler = new char[tutulanKelime.Length];
            for (int i = 0; i < tutulanKelime.Length; i++)
            {
                tahminHarfler[i] = '_';
            }

            int kalanTahminHakki = 7;
            bool kelimeBulundu = false;

            Console.WriteLine("Kelimeyi Tahmin Et!");

            while (kalanTahminHakki > 0 && !kelimeBulundu)
            {
                Console.WriteLine();
                Console.WriteLine("Tahmin harfler: " + string.Join(" ", tahminHarfler));
                Console.WriteLine("Kalan tahmin hakkı: " + kalanTahminHakki);

                Console.Write("Bir harf tahmin edin: ");
                string tahmin = Console.ReadLine().ToLower();

                if (tahmin.Length != 1)
                {
                    Console.WriteLine("Sadece bir harf tahmin edin!");
                    continue;
                }

                char tahminHarf = tahmin[0];

                bool harfBulundu = false;

                for (int i = 0; i < tutulanKelime.Length; i++)
                {
                    if (tutulanKelime[i] == tahminHarf)
                    {
                        tahminHarfler[i] = tahminHarf;
                        harfBulundu = true;
                    }
                }

                if (harfBulundu)
                {
                    Console.WriteLine("Harf doğru!");
                }
                else
                {
                    Console.WriteLine("Harf yanlış!");
                    kalanTahminHakki--;
                }

                if (string.Join("", tahminHarfler) == tutulanKelime)
                {
                    kelimeBulundu = true;
                }
            }

            Console.WriteLine();

            if (kelimeBulundu)
            {
                Console.WriteLine("Tebrikler! Kelimeyi doğru tahmin ettiniz. Tutulan kelime: " + tutulanKelime);
            }
            else
            {
                Console.WriteLine("Maalesef, tahmin hakkınız bitti. Tutulan kelime: " + tutulanKelime);
            }

            Console.WriteLine("oyun demo sürümü olup geliştirilme aşamasındadır. ");

            Console.WriteLine("Çıkışınız yapılıyor...");






            
        }


       






    }
    
}    
