using System;

namespace diziler

{
     class Program
    {
        static void Main(string[]args)
        {
            // dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim

            renkler[0] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngülerle dizi kullanımı 
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.Write("Lütfen dizinin eleman sayısını giriniz.");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}.sayısı giriniz: ", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            
            foreach (var sayi in sayıDizisi)
            {
                toplam+= sayi;
            }

            Console.WriteLine("Ortalama:"+ toplam/diziUzunlugu);








        }
    }
}

