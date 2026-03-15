using System;

namespace TP_MODUL4_103022400060
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==testing==");
            KodePos kp = new KodePos();
            string kelurahan = "Batununggal";
            Console.WriteLine($"Kode pos {kelurahan}: {kp.getKodePos(kelurahan)}");

            string kelurahanLain = "Sukabirus";
            Console.WriteLine($"Kode pos {kelurahanLain}: {kp.getKodePos(kelurahanLain)}");

            DoorMachine pintu = new DoorMachine();
            pintu.BukaPintu();  
            pintu.BukaPintu();  
            pintu.KunciPintu(); 
            pintu.KunciPintu(); 
        }
    }
}