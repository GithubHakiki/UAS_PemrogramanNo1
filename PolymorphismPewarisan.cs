using System;

class Program
{
    // Kelas dasar Kendaraan
    class Kendaraan
    {
        private string merek; // Variabel private untuk menyimpan nilai merek kendaraan
        private string model; // Variabel private untuk menyimpan nilai model kendaraan
        private int tahun; // Variabel private untuk menyimpan nilai tahun kendaraan

        public virtual string Merek // Properti virtual untuk mengakses dan mengubah nilai merek kendaraan
        {
            get { return merek; }
            set { merek = value; }
        }

        public virtual string Model // Properti virtual untuk mengakses dan mengubah nilai model kendaraan
        {
            get { return model; }
            set { model = value; }
        }

        public virtual int Tahun // Properti virtual untuk mengakses dan mengubah nilai tahun kendaraan
        {
            get { return tahun; }
            set { tahun = value; }
        }
    }

    // Kelas turunan Mobil yang merupakan subclass dari Kendaraan
    class Mobil : Kendaraan
    {
        private int jumlahPintu; // Variabel private untuk menyimpan nilai jumlah pintu kendaraan

        public override int Tahun // Override properti Tahun dari kelas induk Kendaraan
        {
            get { return base.Tahun; } // Menggunakan implementasi dari kelas induk
            set
            {
                if (value >= 2000 && value <= DateTime.Now.Year)
                    base.Tahun = value; // Menggunakan implementasi dari kelas induk
                else
                    Console.WriteLine("Tahun mobil tidak valid!");
            }
        }

        public int JumlahPintu // Properti untuk mengakses dan mengubah nilai jumlah pintu kendaraan
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

        // Menampilkan data mobil yang ditambahkan
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
