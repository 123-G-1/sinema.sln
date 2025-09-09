using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salon s1 = new Salon();
            Salon s2 = new Salon();
            Salon s3 = new Salon();
            s1.Kapasite = 50;
            s2.Kapasite = 40;
            s3.Kapasite = 30;
            int secim1 = 0;
            int secim2 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 Salon 1 işlemleri");
                Console.WriteLine("2 Salon 2 işlemleri");
                Console.WriteLine("3 Salon 3 işlemleri");
                Console.WriteLine("4 -Durum Görüntüle: ");
                Console.WriteLine("5 -Çıkış");
                Console.WriteLine();
                Console.Write("İşlem seçiniz: ");
                secim1 = Convert.ToInt32(Console.ReadLine());

                if (secim1 == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Salon 1 işlemleri");
                        Console.WriteLine("1 - Öğrenci Bileti Satışı");
                        Console.WriteLine("2 - Tam Bilet Satışı");
                        Console.WriteLine("3 - Tam Bilet İptali");
                        Console.WriteLine("4 - Durum Görüntüle");
                        Console.WriteLine("5 - Geri Dön");
                        Console.WriteLine();
                        Console.Write("İşlem seçiniz: ");
                        secim2 = Convert.ToInt32(Console.ReadLine());


                        if (secim2 == 1)
                        {
                            s1.ogrenciBiletSatısı();
                            
                           
                        }
                        else if (secim2 == 2)
                        {
                            s1.tamBiletSatısı();
                          
                        }
                        else if (secim2 == 3)
                        {
                            s1.TamBiletIptali();
                          
                        }
                        else if (secim2 == 4)
                        {
                            Console.Clear();
                            s1.DurumGoruntule();
                            Console.ReadLine();
                        }
                        else if (secim2 == 5)
                        { 
                            Console.WriteLine("Geri dönülüyor...");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim");
                            Console.ReadLine();
                        }
                    } while (secim2 != 5);

                }

                else if (secim1==2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Salon 2 işlemleri");
                        Console.WriteLine("1 - Öğrenci Bileti Satışı");
                        Console.WriteLine("2 - Tam Bilet Satışı");
                        Console.WriteLine("3 - Bilet İptali");
                        Console.WriteLine("4 - Durum Görüntüle");
                        Console.WriteLine("5 - Geri Dön");
                        Console.WriteLine();
                        Console.Write("İşlem seçiniz: ");
                        secim2 = Convert.ToInt32(Console.ReadLine());

                        if (secim2 == 1)
                        {
                            s2.ogrenciBiletSatısı();
                            Console.WriteLine("Öğrenci bileti satışı gerçekleşti");

                        }
                        else if (secim2 == 2)
                        {
                            s2.tamBiletSatısı();
                            Console.WriteLine("Tam bilet satışı  gerçekleşti");

                        }
                        else if (secim2 == 3)
                        {
                            s2.TamBiletIptali();
                            Console.WriteLine("Bilet iptali gerçekti");

                        }
                        else if (secim2 == 4)
                        {
                            Console.Clear();
                            s2.DurumGoruntule();
                            Console.ReadLine();
                        }
                        else if (secim2 == 5)
                        {
                            Console.WriteLine("Geri dönülüyor...");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim");
                            Console.ReadLine();
                        }
                    } while (secim2 != 5);

                }
                else if(secim1==3)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Salon 3 işlemleri");
                        Console.WriteLine("1 - Öğrenci Bileti Satışı");
                        Console.WriteLine("2 - Tam Bilet Satışı");
                        Console.WriteLine("3 - Bilet İptali");
                        Console.WriteLine("4 - Durum Görüntüle");
                        Console.WriteLine("5 - Geri Dön");
                        Console.WriteLine();
                        Console.Write("İşlem seçiniz: ");
                        secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 1)
                        {
                            s3.ogrenciBiletSatısı();
                            Console.WriteLine("Öğrenci bileti satışı gerçekleşti");

                        }
                        else if (secim2 == 2)
                        {
                            s3.tamBiletSatısı();
                            Console.WriteLine("Tam bilet satışı  gerçekleşti");

                        }
                        else if (secim2 == 3)
                        {
                            s3.TamBiletIptali();
                            Console.WriteLine("Bilet iptali gerçekti");

                        }
                        else if (secim2 == 4)
                        {
                            Console.Clear();
                            s3.DurumGoruntule();
                            Console.ReadLine();
                        }
                        else if (secim2 == 5)
                        {
                            Console.WriteLine("Geri dönülüyor...");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim");
                            Console.ReadLine();
                        }
                    } while (secim2 != 5);
                }
                else if (secim1 == 4)
                {
                    s1.DurumGoruntule();
                    s2.DurumGoruntule();
                    s3.DurumGoruntule();

                }
                else if (secim1 == 5)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                }





            }    while (secim1 != 5);
        }

    } 
}
