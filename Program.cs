using System;

namespace WhileForeach
{

    class Program
    {

        static void Main(string[] args)
        {

            double girilen = 0;
            Console.WriteLine("Sayı Giriniz");
            girilen=Convert.ToInt32(Console.ReadLine());

            int count = 1;
            double toplam = 0;

            while (count <= girilen)
            {
                toplam += count;
                count++;
            }

            Console.WriteLine(toplam / girilen);

            string[] arabalar = { "BMW", "Mercedes", "Volkwagen" };

            foreach (var araba in arabalar)  //"var" tipi belli olmayan genel bir tanımlama ifadesidir. 
            {
                Console.WriteLine(araba);
            }

        }

    }

}