using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_WorkersUnion
{
    internal class Lokasi
    {
        public enum Provinsi { NanggroeAcehDarusallam, SumateraUtara, SumateraSelatan, SumateraBarat, Bengkulu, 
            Riau, KepulauanRiau, Jambi, Lampung, BangkaBelitung, KalimantanBarat, KalimantanTimur, KalimantanSelatan, KalimantanTengah, 
            KalimantanUtara, Banten, DKIJakarta, JawaBarat, JawaTengah, DaerahIstimewaYogyakarta, JawaTimur, Bali, NusaTenggaraTimur, 
            NusaTenggaraBarat, SulawesiBarat, SulawesiTengah, SulawesiUtara, SulawesiTenggara, SulawesiSelatan, MalukuUtara, Maluku, Papua }
        public static string[] getKota(int provinsiIndex)
        {
            string[][] kotaDiProvinsi;
            kotaDiProvinsi = new string[38][];
            kotaDiProvinsi[0] = new string[] { "Banda Aceh", "Langsa", "Lhokseumawe", "Sabang", "Subulussalam"};
            kotaDiProvinsi[1] = new string[] { "Binjai", "Gunungsitoli", "Medan", "Padangsidimpuan", "Sibolga", "Tanjungbalai", "Tebing Tinggi" };
            kotaDiProvinsi[2] = new string[] { "Lubuklinggau", "Pagar Alam", "Palembang", "Prabumulih" };
            kotaDiProvinsi[3] = new string[] { "Bukittinggi", "Padang", "Padang Panjang", "Pariaman", "Payakumbuh", "Sawahlunto", "Solok"};
            kotaDiProvinsi[4] = new string[] { "Bengkulu" };
            kotaDiProvinsi[5] = new string[] { "Dumai", "Pekanbaru" };
            kotaDiProvinsi[6] = new string[] { "Batam", "Tanjungpinang" };
            kotaDiProvinsi[7] = new string[] { "Sungai Penuh", "Jambi" };
            kotaDiProvinsi[8] = new string[] { "Bandar Lampung",  "Metro"};
            kotaDiProvinsi[9] = new string[] { "Pangkalpinang"};
            kotaDiProvinsi[10] = new string[] { "Pontianak", "Singkawang" };
            kotaDiProvinsi[11] = new string[] { "Balikpapan", "Bontang", "Samarinda", "Nusantara" };
            kotaDiProvinsi[12] = new string[] { "Banjarbaru", "Banjarmasin" };
            kotaDiProvinsi[13] = new string[] { "Palangka Raya" };
            kotaDiProvinsi[14] = new string[] { "Tarakan"};
            kotaDiProvinsi[15] = new string[] { "Cilegon", "Serang", "Tangerang Selatan", "Tangerang" };
            kotaDiProvinsi[16] = new string[] { "Jakarta Barat", "Jakarta Timur", "Jakarta Pusat", "Jakarta Selatan", "Jakarta Utara" };
            kotaDiProvinsi[17] = new string[] { "Bandung", "Bekasi", "Bogor", "Cimahi", "Cirebon", "Depok", "Sukabumi", "Tasikmalaya", "Banjar"};
            kotaDiProvinsi[18] = new string[] { "Magelang", "Pekalongan", "Salatiga", "Semarang", "Surakarta", "Tegal" };
            kotaDiProvinsi[19] = new string[] { "Yogyakarta" };
            kotaDiProvinsi[20] = new string[] { "Batu", "Blitar", "Kediri", "Madidun", "Malang", "Mojokerto", "Pasuruhan", "Probolinggo", "Surabaya"};
            kotaDiProvinsi[21] = new string[] { "Denpasar"};
            kotaDiProvinsi[22] = new string[] { "Kupang" };
            kotaDiProvinsi[23] = new string[] { "Bima", "Mataram" };
            kotaDiProvinsi[24] = new string[] { "Mamuju"};
            kotaDiProvinsi[25] = new string[] { "Palu"};
            kotaDiProvinsi[26] = new string[] { "Bitung", "Kotamobagu", "Manado", "Tomohon"};
            kotaDiProvinsi[27] = new string[] { "Baubau", "Kendari" };
            kotaDiProvinsi[28] = new string[] { "Makassar", "Palopo", "Parepare" };
            kotaDiProvinsi[29] = new string[] { "Ternate", "Tidore Kepulauan" };
            kotaDiProvinsi[30] = new string[] { "Ambon", "Tual" };
            kotaDiProvinsi[31] = new string[] { "Jayapura"};
            return kotaDiProvinsi[provinsiIndex];
        }
    }
}
