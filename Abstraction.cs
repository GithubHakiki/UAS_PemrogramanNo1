using System;

class Program
{
    abstract class Kendaraan
    {
        private string merek;
        private string model;
        private int tahun;

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

        public abstract int JumlahPintu { get; set; } // Properti abstrak

        public abstract void InformasiKendaraan(); // Metode abstrak
    }

    class Mobil : Kendaraan
    {
        private int jumlahPintu;

        public override int JumlahPintu
        {
            get { return jumlahPintu; }
            set { jumlahPintu = value; }
        }

        public override void InformasiKendaraan()
        {
            Console.WriteLine("Merek: " + Merek);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Tahun: " + Tahun);
            Console.WriteLine("Jumlah Pintu: " + JumlahPintu);
        }
    }

    // Fungsi untuk menambah data mobil
    static void TambahDataMobil(Mobil mobil)
    {
        Console.WriteLine("Masukkan data mobil:");

        Console.Write("Merek: ");
        mobil.Merek = Console.ReadLine(); // Mengambil input dari pengguna dan mengatur nilai merek mobil

        Console.Write("Model: ");
        mobil.Model = Console.ReadLine(); // Mengambil input dari pengguna dan mengatur nilai model mobil

        Console.Write("Tahun: ");
        mobil.Tahun = int.Parse(Console.ReadLine()); // Mengambil input dari pengguna dan mengatur nilai tahun mobil

        Console.Write("Jumlah Pintu: ");
        mobil.JumlahPintu = int.Parse(Console.ReadLine()); // Mengambil input dari pengguna dan mengatur nilai jumlah pintu mobil
    }

    static void Main(string[] args)
    {
        // Menampilkan sata mobil awal
        Mobil mobil = new Mobil();
        mobil.Merek = "Honda";
        mobil.Model = "Civic";
        mobil.Tahun = 2020;
        mobil.JumlahPintu = 4;

        mobil.InformasiKendaraan();

        Console.WriteLine();

        // Menampilkan data mobil yang ditambahkan
        TambahDataMobil(mobil);

        Console.WriteLine();

        Console.WriteLine("Data mobil setelah ditambah:");
        mobil.InformasiKendaraan();

        Console.ReadKey();
    }
}
