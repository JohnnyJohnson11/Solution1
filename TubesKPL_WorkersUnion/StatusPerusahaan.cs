using System;
using System.Collections.Generic;

namespace TubesKPL_WorkersUnion
{
    public enum StatusPerusahaan
    {
        MemasukkanInfoPerusahaan,
        Disetujui,
        Ditolak
    }

    public class PerusahaanData
    {
        public string Nama { get; set; }
        public string Email { get; set; }
        public string NomorTelepon { get; set; }
        public string Deskripsi { get; set; }
        public StatusPerusahaan Status { get; set; }
    }

    public class StatusPerusahaanMachine
    {
        private StatusPerusahaan currentState;
        private List<PerusahaanData> daftarPerusahaan;

        public StatusPerusahaanMachine()
        {
            currentState = StatusPerusahaan.MemasukkanInfoPerusahaan;
            daftarPerusahaan = new List<PerusahaanData>();
        }

        public void MulaiRegistrasi()
        {
            Console.WriteLine("Memulai registrasi perusahaan. Masukkan informasi perusahaan.");
            Console.WriteLine("Masukkan Nama Perusahaan: ");
            string namaPerusahaan = Console.ReadLine();
            Console.WriteLine("Masukkan Email Perusahaan: ");
            string emailPerusahaan = Console.ReadLine();
            Console.WriteLine("Masukkan Nomor Telepon Perusahaan: ");
            string nomorTeleponPerusahaan = Console.ReadLine();
            Console.WriteLine("Masukkan Deskripsi Perusahaan: ");
            string deskripsiPerusahaan = Console.ReadLine();
            TambahPerusahaan(namaPerusahaan, emailPerusahaan, nomorTeleponPerusahaan, deskripsiPerusahaan);
        }

        public void TambahPerusahaan(string nama, string email, string nomorTelepon, string deskripsi)
        {
            PerusahaanData perusahaanBaru = new PerusahaanData
            {
                Nama = nama,
                Email = email,
                NomorTelepon = nomorTelepon,
                Deskripsi = deskripsi,
                Status = StatusPerusahaan.MemasukkanInfoPerusahaan
            };

            daftarPerusahaan.Add(perusahaanBaru);
            Console.WriteLine("Informasi perusahaan berhasil ditambahkan.");
        }

        public void SetujuiPerusahaan(string namaPerusahaan)
        {
            var perusahaan = daftarPerusahaan.Find(p => p.Nama == namaPerusahaan);
            if (perusahaan != null)
            {
                perusahaan.Status = StatusPerusahaan.Disetujui;
                Console.WriteLine($"Registrasi perusahaan {namaPerusahaan} disetujui.");
            }
            else
            {
                Console.WriteLine($"Registrasi perusahaan {namaPerusahaan} tidak ditemukan.");
            }
        }

        public void TolakPerusahaan(string namaPerusahaan)
        {
            var perusahaan = daftarPerusahaan.Find(p => p.Nama == namaPerusahaan);
            if (perusahaan != null)
            {
                perusahaan.Status = StatusPerusahaan.Ditolak;
                Console.WriteLine($"Registrasi perusahaan {namaPerusahaan} ditolak.");
            }
            else
            {
                Console.WriteLine($"Registrasi perusahaan {namaPerusahaan} tidak ditemukan.");
            }
        }

        public void TunjukkanStatusRegistrasi()
        {
            Console.WriteLine("Status Registrasi Perusahaan:");
            foreach (var perusahaan in daftarPerusahaan)
            {
                string statusString = perusahaan.Status switch
                {
                    StatusPerusahaan.Disetujui => "Disetujui",
                    StatusPerusahaan.Ditolak => "Ditolak",
                    _ => "Pending"
                };
                Console.WriteLine($"Nama: {perusahaan.Nama}, Status: {statusString}");
            }
        }

        public void ResetSemuaStatus()
        {
            daftarPerusahaan.Clear();
            currentState = StatusPerusahaan.MemasukkanInfoPerusahaan;
            Console.WriteLine("Semua status perusahaan telah diatur ulang.");
        }
    }
}
