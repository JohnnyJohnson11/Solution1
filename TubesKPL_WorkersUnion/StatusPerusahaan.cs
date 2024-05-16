using System;
using System.Collections.Generic;

namespace TubesKPL_WorkersUnion
{
    public enum StatusPerusahaan
    {
        MemasukkanInfoPerusahaan,
        Verifikasi,
        Disetujui,
        Ditolak
    }

    public class Perusahaan
    {
        public string Nama { get; set; }
        public string Email { get; set; }
        public string NomorTelepon { get; set; }
        public string Lokasi { get; set; }
        public string Deskripsi { get; set; }
    }

    public class StatusPerusahaanMachine
    {
        private StatusPerusahaan currentState;
        private List<Perusahaan> daftarPerusahaan;

        public StatusPerusahaanMachine()
        {
            currentState = StatusPerusahaan.MemasukkanInfoPerusahaan;
            daftarPerusahaan = new List<Perusahaan>();
        }

        public void MulaiRegistrasi()
        {
            Console.WriteLine("Memulai registrasi perusahaan. Masukkan informasi perusahaan.");
        }

        public void TambahPerusahaan(string nama, string email, string nomorTelepon, string lokasi, string deskripsi)
        {
            Perusahaan perusahaanBaru = new Perusahaan
            {
                Nama = nama,
                Email = email,
                NomorTelepon = nomorTelepon,
                Lokasi = lokasi,
                Deskripsi = deskripsi
            };

            daftarPerusahaan.Add(perusahaanBaru);
            Console.WriteLine("Informasi perusahaan berhasil ditambahkan.");
        }

        public void SetujuiPerusahaan(string namaPerusahaan)
        {
            var perusahaan = daftarPerusahaan.Find(p => p.Nama == namaPerusahaan);
            if (perusahaan != null)
            {
                Console.WriteLine($"Perusahaan {namaPerusahaan} berhasil disetujui.");
            }
            else
            {
                Console.WriteLine($"Perusahaan {namaPerusahaan} tidak ditemukan.");
            }
        }

        public void TolakPerusahaan(string namaPerusahaan)
        {
            var perusahaan = daftarPerusahaan.Find(p => p.Nama == namaPerusahaan);
            if (perusahaan != null)
            {
                Console.WriteLine($"Perusahaan {namaPerusahaan} berhasil ditolak.");
            }
            else
            {
                Console.WriteLine($"Perusahaan {namaPerusahaan} tidak ditemukan.");
            }
        }

        public void TunjukkanStatusRegistrasi()
        {
            Console.WriteLine("Status Registrasi Perusahaan:");
            foreach (var perusahaan in daftarPerusahaan)
            {
                Console.WriteLine($"Nama: {perusahaan.Nama}, Status: {(currentState == StatusPerusahaan.Disetujui ? "Disetujui" : (currentState == StatusPerusahaan.Ditolak ? "Ditolak" : "Pending"))}");
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
