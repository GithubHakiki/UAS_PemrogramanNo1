using System;

class Program
{
    class Kendaraan
    {
        protected string merek; // Variabel protected untuk menyimpan nilai merek kendaraan
        protected string model; // Variabel protected untuk menyimpan nilai model kendaraan
        protected int tahun; // Variabel protected untuk menyimpan nilai tahun kendaraan

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
    }

    // Inheritance
    class Mobil : Kendaraan
    {
        private int jumlahPintu; // Variabel private untuk menyimpan nilai jumlah pintu kendaraan

        public int JumlahPintu
        {
            get { return jumlahPintu; }
            set { jumlahPintu = value; }
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
        // Menampilkan data mobil awal
        Mobil mobil = new Mobil();
        mobil.Merek = "Honda";
        mobil.Model = "Civic";
        mobil.Tahun = 2020;
        mobil.JumlahPintu = 4;

        Console.WriteLine("Merek: " + mobil.Merek);
        Console.WriteLine("Model: " + mobil.Model);
        Console.WriteLine("Tahun: " + mobil.Tahun);
        Console.WriteLine("Jumlah Pintu: " + mobil.JumlahPintu);

        Console.WriteLine();

        // Menampilkan data mobil yang telah ditambahkan
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
