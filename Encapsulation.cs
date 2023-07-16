using System;

class Program
{
    // Kelas Kendaraan dengan konsep encapsulation
    class Kendaraan
    {
        private string merek; // Variabel private untuk menyimpan nilai merek kendaraan
        private string model; // Variabel private untuk menyimpan nilai model kendaraan
        private int tahun; // Variabel private untuk menyimpan nilai tahun kendaraan
        private int jumlahPintu; // Variabel private untuk menyimpan nilai jumlah pintu kendaraan

        public string Merek // Properti public untuk mengakses dan mengubah nilai merek kendaraan
        {
            get { return merek; } // Mengembalikan nilai merek kendaraan
            set { merek = value; } // Mengatur nilai merek kendaraan
        }

        public string Model // Properti public untuk mengakses dan mengubah nilai model kendaraan
        {
            get { return model; } // Mengembalikan nilai model kendaraan
            set { model = value; } // Mengatur nilai model kendaraan
        }

        public int Tahun // Properti public untuk mengakses dan mengubah nilai tahun kendaraan
        {
            get { return tahun; } // Mengembalikan nilai tahun kendaraan
            set { tahun = value; } // Mengatur nilai tahun kendaraan
        }

        public int JumlahPintu // Properti public untuk mengakses dan mengubah nilai jumlah pintu kendaraan
        {
            get { return jumlahPintu; } // Mengembalikan nilai jumlah pintu kendaraan
            set { jumlahPintu = value; } // Mengatur nilai jumlah pintu kendaraan
        }
    }

    // Fungsi untuk menambahkan data mobil
    static void TambahDataMobil(Kendaraan kendaraan)
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
        // Data mobil awal
        Kendaraan mobil = new Kendaraan();
        mobil.Merek = "Honda";
        mobil.Model = "Civic";
        mobil.Tahun = 2020;
        mobil.JumlahPintu = 4;

        Console.WriteLine("Data mobil awal:");
        Console.WriteLine("Merek: " + mobil.Merek); // Menampilkan merek mobil
        Console.WriteLine("Model: " + mobil.Model); // Menampilkan model mobil
        Console.WriteLine("Tahun: " + mobil.Tahun); // Menampilkan tahun mobil
        Console.WriteLine("Jumlah Pintu: " + mobil.JumlahPintu); // Menampilkan jumlah pintu mobil

        Console.WriteLine();

        // Menambahkan data mobil
        TambahDataMobil(mobil);

        Console.WriteLine();

        Console.WriteLine("Data mobil setelah ditambah:");
        Console.WriteLine("Merek: " + mobil.Merek); // Menampilkan merek mobil setelah ditambahkan
        Console.WriteLine("Model: " + mobil.Model); // Menampilkan model mobil setelah ditambahkan
        Console.WriteLine("Tahun: " + mobil.Tahun); // Menampilkan tahun mobil setelah ditambahkan
        Console.WriteLine("Jumlah Pintu: " + mobil.JumlahPintu); // Menampilkan jumlah pintu mobil setelah ditambahkan

        Console.ReadKey();
    }
}