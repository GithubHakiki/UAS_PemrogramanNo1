using System;

class Program
{
    // Interface IKendaraan
    interface IKendaraan
    {
        string Merek { get; set; }
        string Model { get; set; }
        int Tahun { get; set; }
        int JumlahPintu { get; set; }
    }

    // Kelas Kendaraan yang mengimplementasikan interface IKendaraan
    class Kendaraan : IKendaraan
    {
        private string merek;
        private string model;
        private int tahun;
        private int jumlahPintu;

        public string Merek
        {
            get { return merek; }
            set { merek = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Tahun
        {
            get { return tahun; }
            set { tahun = value; }
        }

        public int JumlahPintu
        {
            get { return jumlahPintu; }
            set { jumlahPintu = value; }
        }
    }

    // Fungsi untuk menambah data mobil
    static void TambahDataMobil(IKendaraan kendaraan)
    {
        Console.WriteLine("Masukkan data mobil:");

        Console.Write("Merek: ");
        kendaraan.Merek = Console.ReadLine(); // Mengambil input dari pengguna dan mengatur nilai merek mobil

        Console.Write("Model: ");
        kendaraan.Model = Console.ReadLine(); // Mengambil input dari pengguna dan mengatur nilai model mobil

        Console.Write("Tahun: ");
        kendaraan.Tahun = int.Parse(Console.ReadLine()); // Mengambil input dari pengguna dan mengatur nilai tahun mobil

        Console.Write("Jumlah Pintu: ");
        kendaraan.JumlahPintu = int.Parse(Console.ReadLine()); // Mengambil input dari pengguna dan mengatur nilai jumlah pintu mobil
    }

    static void Main(string[] args)
    {
        IKendaraan mobil = new Kendaraan();
        mobil.Merek = "Honda";
        mobil.Model = "Civic";
        mobil.Tahun = 2020;
        mobil.JumlahPintu = 4;

        Console.WriteLine("Merek: " + mobil.Merek);
        Console.WriteLine("Model: " + mobil.Model);
        Console.WriteLine("Tahun: " + mobil.Tahun);
        Console.WriteLine("Jumlah Pintu: " + mobil.JumlahPintu);

        Console.WriteLine();

        TambahDataMobil(mobil);

        Console.WriteLine();

        Console.WriteLine("Data mobil setelah ditambah:");
        Console.WriteLine("Merek: " + mobil.Merek);
        Console.WriteLine("Model: " + mobil.Model);
        Console.WriteLine("Tahun: " + mobil.Tahun);
        Console.WriteLine("Jumlah Pintu: " + mobil.JumlahPintu);

        Console.ReadKey();
    }
}
