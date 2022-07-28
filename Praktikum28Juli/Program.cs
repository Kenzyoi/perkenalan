using System;

class Program{
    static void Main(String[] args){
        string nama;
        Console.WriteLine("Masukkan nama : ");
        nama = Console.ReadLine();
        Console.WriteLine("Nama saya "+nama);
        Console.WriteLine("Tahun Lahir : ");
        int tahunlahir = int.Parse (Console.ReadLine());
        Console.WriteLine($"Saya Lahir Tahun {tahunlahir}");
    }
}