using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Mahasiswa mhs = new Mahasiswa();
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine();
            Console.WriteLine("NIM : ");
            mhs.Nim = Console.ReadLine();
            Console.WriteLine("Nama : ");
            mhs.Nama = Console.ReadLine();
            Console.WriteLine("Jenis Kelamin [L/P] : ");
            mhs.JenisKelamin = Console.ReadLine().ToUpper() == "L" ? "Laki-Laki" : "Perempuan";
            Console.WriteLine("IPK : ");
            mhs.IPK = Console.ReadLine();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
            daftarMahasiswa.Add(mhs);
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Data Mahasiswa");
            Console.WriteLine();
            var nomer = 1;

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", nomer, mhs.Nim, mhs.Nama, mhs.JenisKelamin, mhs.IPK);
                nomer++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
