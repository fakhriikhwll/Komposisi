using System;

namespace LatihanKomposisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Demo Relasi Komposisi";

            Mobil mobil = new Mobil();
            mobil.Merk = "BMW";

            Console.WriteLine("Merk mobil: {0}, Tipe mesin: {1}", mobil.Merk, mobil.GetInfoMesin().Type);

            Console.ReadKey();


        }

    }
}