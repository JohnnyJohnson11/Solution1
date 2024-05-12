using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TubesKPL_WorkersUnion
{
    public class LoginConfig
    {
        public Config ListPengguna;
        private const string filepath = @"login_convig.json";
        public LoginConfig()
        {
            ListPengguna = new Config();
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
            ListPengguna = JsonSerializer.Deserialize<Config>(hasil);
        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            string tulisan = JsonSerializer.Serialize(ListPengguna, options);
            File.WriteAllText(filepath, tulisan);
        }

        public void SetDefault()
        {
            ListPengguna = new Config();
            ListPengguna.pengguna.Add(new Pengguna("Admin", "Admin"));
        }

        public int SearchPengguna(string username)
        {
            int i = 0;
            foreach (Pengguna pengguna in ListPengguna.pengguna)
            {
                if (pengguna.username == username)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}

