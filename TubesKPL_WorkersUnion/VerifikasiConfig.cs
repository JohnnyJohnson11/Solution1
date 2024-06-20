

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace TubesKPL_WorkersUnion
{
    public class VerifikasiConfig
    {
        public Verifikasi_Config ListVerifikasi;
        private const string filepath = @"verifikasi_config.json";
        public VerifikasiConfig()
        {
            ListVerifikasi = new Verifikasi_Config();
            try
            {
                ReadConfigFile();
            }
            catch
            {
                SetDefault();
                WriteConfigFile();
            }
        }

        public void ReadConfigFile()
        {
            string hasil = File.ReadAllText(filepath);
            ListVerifikasi = JsonSerializer.Deserialize<Verifikasi_Config>(hasil);

        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            string tulisan = JsonSerializer.Serialize(ListVerifikasi, options);
            File.WriteAllText(filepath, tulisan);
        }

        public void SetDefault()
        {
            ListVerifikasi = new Verifikasi_Config();
            LoginConfig loginConfig = new LoginConfig();
            for (int i = 0; i < loginConfig.ListPengguna.pengguna.Count; i++)
            {
                if (loginConfig.ListPengguna.pengguna[i].perusahaan.Status == StatusPerusahaan.MemasukkanInfoPerusahaan)
                {
                    ListVerifikasi.verifikasi.Add(new Verifikasi(loginConfig.ListPengguna.pengguna[i].perusahaan.idPerusahaan));
                }
            }
        }
    }
}

//tes satu dua tiga