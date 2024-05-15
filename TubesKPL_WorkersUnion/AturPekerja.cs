using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_WorkersUnion
{
    public class AturPekerja
    {
        private Dictionary<string, Pekerja> daftarPekerja;

        public AturPekerja()
        {
            daftarPekerja = new Dictionary<string, Pekerja>();
        }

        public void TambahPekerja(string id, string nama, string posisi)
        {
            daftarPekerja[id] = new Pekerja(nama, posisi);
        }

        public void HapusPekerja(string id)
        {
            if (daftarPekerja.ContainsKey(id))
            {
                daftarPekerja.Remove(id);
            }
            else
            {
                Console.WriteLine($"Pekerja dengan ID {id} tidak ditemukan.");
            }
        }

        public void TampilkanPekerja()
        {
            Console.WriteLine("Daftar Pekerja:");
            foreach (var pekerja in daftarPekerja.Values)
            {
                Console.WriteLine($"- {pekerja.Nama}, {pekerja.Posisi}");
            }
        }
    }

    public class Pekerja
    {
        public string Nama { get; set; }
        public string Posisi { get; set; }

        public Pekerja(string nama, string posisi)
        {
            Nama = nama;
            Posisi = posisi;
        }
    }
}
