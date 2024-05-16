using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_WorkersUnion
{
    public class AturGajiPekerjaan
    {
        public enum JenisPekerjaan { TidakDiketahui }

        private static Dictionary<JenisPekerjaan, double> gajiPerJenis = new Dictionary<JenisPekerjaan, double>();

        public static void UpdateGaji(string jenis, double gaji)
        {
            JenisPekerjaan jenisPekerjaan = (JenisPekerjaan)Enum.Parse(typeof(JenisPekerjaan), jenis);

            if (gajiPerJenis.ContainsKey(jenisPekerjaan))
            {
                gajiPerJenis[jenisPekerjaan] = gaji;
                Console.WriteLine($"Gaji untuk jenis pekerjaan {jenis} berhasil diperbarui.");
            }
            else
            {
                gajiPerJenis.Add(jenisPekerjaan, gaji);
                Console.WriteLine($"Gaji untuk jenis pekerjaan {jenis} berhasil ditambahkan.");
            }
        }

        public static double DapatkanGaji(JenisPekerjaan jenis)
        {
            if (gajiPerJenis.ContainsKey(jenis))
            {
                return gajiPerJenis[jenis];
            }
            else
            {
                Console.WriteLine($"Gaji untuk jenis pekerjaan {jenis} tidak ditemukan.");
                return 0;
            }
        }
    }
}
