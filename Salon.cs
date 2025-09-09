using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace sinema
{
    internal class Salon
    {
        int kapasite;
        int ogrenciBiletSayisi = 0;
        int tamBiletSayisi = 0;
        int bakiye = 0;
        //int bosKoltukSayisi;
        private int adet;

        public int Kapasite { get => kapasite; set => kapasite = value; }



        public int Bakiye { get => bakiye; }
        //public int BosKoltukSayisi { get => bosKoltukSayisi; }
        public int OgrenciBiletSayisi { get => ogrenciBiletSayisi; }
        public int TamBiletSayisi { get => tamBiletSayisi; }

        public void tamBiletSatısı()
        {
            Console.Clear();
            Console.Write("Kaç adet tam bilet satılacak");
            int adet = Convert.ToInt32(Console.ReadLine());
            tamBiletSayisi += adet;
            bakiye += adet * 50;
            Console.WriteLine(adet + " adet Tam bilet satışı gerçekleşti.");
            Console.ReadLine();

        }

        public void ogrenciBiletSatısı()
        {
            Console.Clear();
            Console.Write("Kaç adet öğrenci bileti satılacak");
            int adet = Convert.ToInt32(Console.ReadLine());
            ogrenciBiletSayisi += adet;
            bakiye += adet * 30;
            Console.WriteLine(adet + " adet öğrenci bileti satışı gerçekleşti.");
            Console.ReadLine();
        }
        public void TamBiletIptali()
        {


            Console.Write("Kaç bilet iptal edilecek: ");
            int iptalFiyati = Convert.ToInt32(Console.ReadLine());
            if (adet >tamBiletSayisi)
            {
                Console.WriteLine("İptal edilecek bilet bulunmamaktadır.");

            }
            else
            {
                tamBiletSayisi -= adet
                    ;
                bakiye -= adet * 50;
                Console.WriteLine(adet + " adet Tam bilet iptali gerçekleşti.");
                Console.ReadLine();
            }
            
        }
        public void Ogrecibiletİptal()

        {
          Console.Write("Kaç bilet iptal edilecek: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            if (adet > ogrenciBiletSayisi)
            {
                Console.WriteLine("İptal edilecek bilet bulunmamaktadır.");
            }
            else
            {
                ogrenciBiletSayisi -= adet;
                bakiye -= adet * 30;
                Console.WriteLine(adet + " adet öğrenci bileti iptali gerçekleşti.");
                Console.ReadLine();
            }

        }

        public void DurumGoruntule()
        {
         Console.WriteLine();
            Console.WriteLine(kapasite + " kapasite");
            Console.WriteLine("Satılan Tam Bilet Sayısı: " + TamBiletSayisi);
            Console.WriteLine("Satılan Öğrenci Bilet Sayısı: " + OgrenciBiletSayisi);
            Console.WriteLine("Boş Koltuk Sayısı:"+(Kapasite - (OgrenciBiletSayisi + TamBiletSayisi)));
            Console.WriteLine("Bakiye: " + Bakiye );
            Console.WriteLine("........");
            Console.WriteLine();


        }




    }
}