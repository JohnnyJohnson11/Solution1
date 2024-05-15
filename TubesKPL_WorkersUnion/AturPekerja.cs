using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_Kelompok8
{
    public class AturGajiPekerjaan
    {
        public enum JenisPekerjaan { TidakDiketahui }

        private static Dictionary<JenisPekerjaan, double> gajiPerJenis = new Dictionary<JenisPekerjaan, double>();

        public static void TambahGaji(string jenis, double gaji)
        {
            JenisPekerjaan jenisPekerjaan;
            if (!Enum.TryParse(jenis, out jenisPekerjaan))
            {
                Console.WriteLine($"Gagal menambahkan gaji: {jenis} bukan jenis pekerjaan yang valid.");
                return;
            }

            if (gajiPerJenis.ContainsKey(jenisPekerjaan))
            {
                Console.WriteLine($"Gaji untuk jenis pekerjaan {jenis} sudah ada dalam daftar.");
            }
            else
            {
                gajiPerJenis.Add(jenisPekerjaan, gaji);
                Console.WriteLine($"Gaji untuk jenis pekerjaan {jenis} berhasil ditambahkan.");
            }
        }

        public static double DapatkanGaji(string jenis)
        {
            JenisPekerjaan jenisPekerjaan;
            if (!Enum.TryParse(jenis, out jenisPekerjaan))
            {
                Console.WriteLine($"Gagal mendapatkan gaji: {jenis} bukan jenis pekerjaan yang valid.");
                return 0;
            }

            if (gajiPerJenis.ContainsKey(jenisPekerjaan))
            {
                return gajiPerJenis[jenisPekerjaan];
            }
            else
            {
                Console.WriteLine($"Gaji untuk jenis pekerjaan {jenis} tidak ditemukan.");
                return 0;
            }
        }
    }
}
