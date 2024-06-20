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
using MySql.Data.MySqlClient;
using System.Text.Json;

namespace TubesKPL_WorkersUnion
{
    public class UnggahVerifikasiConfig
    {
        public Verifikasi_Config ListVerifikasi;
        private const string filepath = @"verifikasi_config.json";

        public UnggahVerifikasiConfig()
        {
            ListVerifikasi = ReadConfigFile<Verifikasi_Config>();
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
            string tulisan = JsonSerializer.Serialize(ListVerifikasi, options);
            LoginConfig loginConfig = new LoginConfig();
            File.WriteAllText(filepath, tulisan);
        }

        public void BuatDataVerifikasi(string idPerusahaan, string kategori, string tanggal, string aset, string alamat)
        {
            Verifikasi_Config obj=ReadConfigFile<Verifikasi_Config>();
            Verifikasi data = new Verifikasi(idPerusahaan);
            data.tambahDataVerifikasi(kategori,tanggal, aset, alamat);
            obj.verifikasi.Add(data);
            ListVerifikasi = obj;
            WriteConfigFile();
        }
        public void HapusDataVerifikasi(string idPerusahaan)
        {
            Verifikasi_Config obj = ReadConfigFile<Verifikasi_Config>();
            for(int i = 0; i < obj.verifikasi.Count; i++)
            {
                if (obj.verifikasi[i].idPerusahaan==idPerusahaan)
                {
                    obj.verifikasi.RemoveAt(i);
                }
            }
            ListVerifikasi = obj;
            WriteConfigFile();
        }
    }
}