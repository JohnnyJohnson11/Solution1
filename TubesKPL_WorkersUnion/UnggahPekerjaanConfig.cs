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

        public Pekerjaan BuatDataPekerjaan(string idPerusahaan, string DeskripsiPekerjaan)
        {
            double gaji;

            try
            {
                AturGajiPekerjaan.JenisPekerjaan jenisEnum = (AturGajiPekerjaan.JenisPekerjaan)Enum.Parse(typeof(AturGajiPekerjaan.JenisPekerjaan), DeskripsiPekerjaan);
                string jenis = jenisEnum.ToString();

                gaji = 1000;

                AturGajiPekerjaan.UpdateGaji(jenis, gaji);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                gaji = 0;
            }

            Pekerjaan data = new Pekerjaan();
            Random rnd = new Random();

            data.idPerusahaan = idPerusahaan;
            data.idPekerjaan = "PKJ" + data.idPerusahaan.Substring(2) + rnd.Next(1000, 2000).ToString();
            data.deskripsiPekerjaan = DeskripsiPekerjaan;

            return data;
        }


        public void TambahData(string username, string idPerusahaan, string DeskripsiPekerjaan, string jenis, double gaji) 
        {
            
            Config obj = ReadConfigFile<Config>();
            for (int i = 0; i < obj.pengguna.Count; i++)
            {
                if (obj.pengguna[i].username == username)
                {
                    Pekerjaan dataPekerjaan = BuatDataPekerjaan(idPerusahaan, DeskripsiPekerjaan);
                    obj.pengguna[i].perusahaan.postinganPekerjaan.Add(dataPekerjaan);
                   
                }
            }
            listPengguna = obj;
            WriteConfigFile();
        }

        public void HapusData(string username, string idPekerjaan)
        {
            Config obj = ReadConfigFile<Config>();
            Pekerjaan PekerjaanTemu = new Pekerjaan();
            for (int i = 0; i < obj.pengguna.Count; i++)
            {
                if (obj.pengguna[i].username == username)
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

