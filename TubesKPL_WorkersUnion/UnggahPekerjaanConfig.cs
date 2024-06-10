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

        public Pekerjaan BuatDataPekerjaan(string idPerusahaan, string judulPekerjaan, int[] lokasi,string gaji,string DeskripsiPekerjaan, string file)
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
            data.pertanyaan = file;

            return data;
        }


        public void TambahData(string idPerusahaan, string judulPekerjaan, int[] lokasi, string gaji, string DeskripsiPekerjaan, string file) 
        {
            
            Config obj = ReadConfigFile<Config>();
            for (int i = 0; i < obj.pengguna.Count; i++)
            {
                if (obj.pengguna[i].perusahaan.idPerusahaan == idPerusahaan)
                {  
                    Pekerjaan dataPekerjaan = new Pekerjaan();
                    dataPekerjaan = BuatDataPekerjaan(idPerusahaan, judulPekerjaan, lokasi, gaji, DeskripsiPekerjaan, file);
                    obj.pengguna[i].perusahaan.postinganPekerjaan.Add(dataPekerjaan);
                }
            }
            listPengguna = obj;
            WriteConfigFile();
        }
        public void TambahLamaran(string idPekerja, string idPekerjaan, string idCv, string jawaban)
        {
            Config obj = ReadConfigFile<Config>();
            for (int i = 0; i < obj.pengguna.Count; i++)
            {
                if (obj.pengguna[i].pekerja.idPekerja == idPekerja)
                {
                    Lamaran dataLamaran = new Lamaran();
                    Random rnd = new Random();
                    dataLamaran.idLamaran = "LM" + idPekerja.Substring(2) + rnd.Next(1000, 2000).ToString();
                    dataLamaran.idCv = idCv;
                    dataLamaran.idPekerja = idPekerja;
                    dataLamaran.idPekerjaan = idPekerjaan;
                    dataLamaran.statusLamaran = "pending";
                    dataLamaran.jawaban = jawaban;
                    obj.pengguna[i].pekerja.lamaranDikirim.Add(dataLamaran);
                    for (int j = 0; j < obj.pengguna.Count; j++)
                    {
                        for (int k = 0; k < obj.pengguna[j].perusahaan.postinganPekerjaan.Count; k++)
                        {
                            if (obj.pengguna[j].perusahaan.postinganPekerjaan[k].idPekerjaan == idPekerjaan)
                            {
                                obj.pengguna[j].perusahaan.postinganPekerjaan[k].lamaranDiterima.Add(dataLamaran);
                            }
                        }
                    }
                }
            }
            listPengguna = obj;
            WriteConfigFile();
        }
        
        public void TambahCv(string idPekerja, string riwayatPendidikan, string riwayatPekerjaan, string skill)
        {
            bool found = false;
            Config obj = ReadConfigFile<Config>();
            int i;
            CV dataCv= new CV();
            dataCv.idPekerja = idPekerja;
            dataCv.riwayatPendidikan= riwayatPendidikan;
            dataCv.riwayatPekerjaan= riwayatPekerjaan;
            dataCv.skill = skill;

            for (i = 0; i < obj.pengguna.Count; i++)
            {
                if (obj.pengguna[i].pekerja.idPekerja == idPekerja)
                {
                    found = true;
                    obj.pengguna[i].pekerja.Cv= dataCv;
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

        public void UbahDataPekerja(string idPekerja, string nama, string tanggalLahir, string email, string noTelepon)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            Config obj = ReadConfigFile<Config>();
            Pengguna penggunaUbahJadi;
            bool found = false;
            for (int i = 0; i<obj.pengguna.Count&&!found; i++)
            {
                if (obj.pengguna[i].pekerja.idPekerja == idPekerja)
                {
                    penggunaUbahJadi=loginConfig.ListPengguna.pengguna[i];
                    penggunaUbahJadi.fullname = nama;
                    penggunaUbahJadi.pekerja.tanggalLahir= tanggalLahir;
                    penggunaUbahJadi.email = email;
                    penggunaUbahJadi.pekerja.noTelepon= noTelepon;
                    obj.pengguna[i] = penggunaUbahJadi;
                    found = true;
                }
                listPengguna = obj;
                WriteConfigFile();
            }
            
        }
        public void UbahDataPerusahaan(string idPerusahaan, string namaPerusahaan, int provinsi, int kota, string email, string noTelepon, string deskripsi)
        {
            LoginConfig loginConfig = new LoginConfig();
            loginConfig.ReadConfigFile();
            Config obj = ReadConfigFile<Config>();
            Perusahaan perusahaanUbahJadi;
            bool found = false;
            for (int i=0;i<obj.pengguna.Count&&!found;i++)
            {
                if (obj.pengguna[i].perusahaan.idPerusahaan == idPerusahaan)
                {
                    perusahaanUbahJadi = loginConfig.ListPengguna.pengguna[i].perusahaan;
                    perusahaanUbahJadi.Nama = namaPerusahaan;
                    perusahaanUbahJadi.lokasi[0] = provinsi;
                    perusahaanUbahJadi.lokasi[1] = kota;
                    perusahaanUbahJadi.Email = email;
                    perusahaanUbahJadi.NomorTelepon = noTelepon;
                    perusahaanUbahJadi.Deskripsi = deskripsi;
                    obj.pengguna[i].perusahaan=perusahaanUbahJadi;
                    found = true;
                }
                listPengguna = obj;
                WriteConfigFile();
            }
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
            Random rnd = new Random();
            penggunaBaru.pekerja.Cv.idCv = "CV"+penggunaBaru.pekerja.idPekerja.Substring(2);
            obj.pengguna.Add(penggunaBaru);
            listPengguna = obj;
            WriteConfigFile();
        }
    }
}

