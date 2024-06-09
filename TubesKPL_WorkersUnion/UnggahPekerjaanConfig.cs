using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;

using System.Text.Json;
using System.Threading.Tasks;
using TubesKPL_WorkersUnion;
using static TubesKPL_WorkersUnion.AturGajiPekerjaan;


namespace TubesKPL_WorkersUnion
{
    public class UnggahPekerjaanConfig
    {
        private const string filepath = @"login_config.json";
        public Config listPengguna;

        public UnggahPekerjaanConfig()
        {
            listPengguna = ReadConfigFile<Config>();
        }

        public U ReadConfigFile<U>()
        {
            string hasilBaca = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<U>(hasilBaca);
        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string tulisan = JsonSerializer.Serialize(listPengguna, options);
            File.WriteAllText(filepath, tulisan);
        }

        public Pekerjaan BuatDataPekerjaan(string idPerusahaan, string judulPekerjaan, int[] lokasi,string gaji,string DeskripsiPekerjaan)
        {
            Pekerjaan data = new Pekerjaan();
            Random rnd = new Random();

            data.idPerusahaan = idPerusahaan;
            data.idPekerjaan = "PKJ" + data.idPerusahaan.Substring(2) + rnd.Next(1000, 2000).ToString();
            data.lokasi = new int[2];
            data.lokasi[0] = lokasi[0];
            data.lokasi[1] = lokasi[1];
            data.gaji = gaji;
            data.judulPekerjaan = judulPekerjaan;
            data.deskripsiPekerjaan = DeskripsiPekerjaan;

            return data;
        }


        public void TambahData(string idPerusahaan, string judulPekerjaan, int[] lokasi, string gaji, string DeskripsiPekerjaan) 
        {
            
            Config obj = ReadConfigFile<Config>();
            for (int i = 0; i < obj.pengguna.Count; i++)
            {
                if (obj.pengguna[i].perusahaan.idPerusahaan == idPerusahaan)
                {  
                    Pekerjaan dataPekerjaan = new Pekerjaan();
                    dataPekerjaan = BuatDataPekerjaan(idPerusahaan, judulPekerjaan, lokasi, gaji, DeskripsiPekerjaan);
                    obj.pengguna[i].perusahaan.postinganPekerjaan.Add(dataPekerjaan);
                   
                }
            }
            listPengguna = obj;
            WriteConfigFile();
        }

        public void HapusData(string idPerusahaan, string idPekerjaan)
        {
            Config obj = ReadConfigFile<Config>();
            Pekerjaan PekerjaanTemu = new Pekerjaan();
            for (int i = 0; i < obj.pengguna.Count; i++)
            {
                if (obj.pengguna[i].perusahaan.idPerusahaan == idPerusahaan)
                {
                    foreach (Pekerjaan pekerjaan in obj.pengguna[i].perusahaan.postinganPekerjaan)
                    {
                        if (pekerjaan.idPekerjaan== idPekerjaan)
                        {
                            PekerjaanTemu = pekerjaan;
                        }
                    }
                }
                if (PekerjaanTemu != null)
                {
                    obj.pengguna[i].perusahaan.postinganPekerjaan.Remove(PekerjaanTemu);
                }
            }
            listPengguna = obj;
            WriteConfigFile();
        }

        public void ShowData(Pengguna pengguna)
        {
            int i = 1;
            foreach (Pekerjaan pekerja in pengguna.perusahaan.postinganPekerjaan)
            {
                Console.WriteLine(pengguna.perusahaan.postinganPekerjaan[i].deskripsiPekerjaan);
                i++;
            }
        }

        public Pengguna SearchPengguna(string username)
        {
            Config obj = ReadConfigFile<Config>();
            foreach (Pengguna pengguna in obj.pengguna)
            {
                if (pengguna.username == username)
                {
                    return pengguna;
                }
            }
            return null;
        }

        public void Register(string fullname, string username, string email, string password)
        {
            Config obj = ReadConfigFile<Config>();
            Pengguna penggunaBaru = new Pengguna(username, password);
            penggunaBaru.fullname = fullname;
            penggunaBaru.email = email;
            obj.pengguna.Add(penggunaBaru);
            listPengguna = obj;
            WriteConfigFile();
        }
    }
}

