using System;
using System.Security.Cryptography;
using System.Text;
using TubesKPL_WorkersUnion;
using UtilityLibraries;

namespace UtilityLibraries
{
    public static class InterfaceMenu
    {
        public static void Function1()
        {
            StatusPerusahaanMachine statusPerusahaanMachine = new StatusPerusahaanMachine();

            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Tambah Pekerjaan dan Gaji");
            Console.WriteLine("4. Kelola Status Registrasi Perusahaan");
            Console.WriteLine("0. Keluar");
            string input = Console.ReadLine();
            while (input != "0")
            {
                if (input == "1")
                {
                    bool found = false;
                    while (!found)
                    {
                        Console.WriteLine("Masukkan Username: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Masukkan Password: ");
                        string password = Console.ReadLine();
                        LoginConfig loginConfig = new LoginConfig();
                        loginConfig.ReadConfigFile();
                        int i;
                        for (i = 0; i < loginConfig.ListPengguna.pengguna.Count; i++)
                        {
                            if (loginConfig.ListPengguna.pengguna[i].username == username && password == loginConfig.ListPengguna.pengguna[i].password)
                            {
                                Console.WriteLine("Email dan Password benar");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Email atau Password salah");
                        }
                    }
                }

                else if (input == "2")
                {
                    Console.WriteLine("Full name: ");
                    string fullname = Console.ReadLine();
                    Console.WriteLine("Username: ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    string password = Console.ReadLine();
                    bool valid = false;
                    bool semuaAngka = true;
                    while (!valid)
                    {
                        try
                        {
                            for (int i = 0; i < password.Length-1&&semuaAngka; i++)
                            {
                                char c= password[i];
                                semuaAngka = semuaAngka && int.TryParse(c.ToString(), out _);
                            }
                            if (semuaAngka)
                            {
                                throw new FormatException("Password harus ada huruf");
                            }
                            valid = true;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Password: ");
                            password = Console.ReadLine();
                        }
                    }
                    UnggahPekerjaanConfig config = new UnggahPekerjaanConfig();
                    config.Register(fullname, username, email, password);
                    Console.WriteLine("Akun Terdaftar");
                }

                else if (input == "4")
                {
                    bool kelolaBerjalan = true;
                    while (kelolaBerjalan)
                    {
                        Console.WriteLine("\n1. Mulai Registrasi Perusahaan");
                        Console.WriteLine("2. Setujui Registrasi");
                        Console.WriteLine("3. Tolak Registrasi");
                        Console.WriteLine("4. Tunjukkan Status Registrasi");
                        Console.WriteLine("5. Reset Semua Status Perusahaan");
                        Console.WriteLine("0. Kembali");
                        Console.Write("Pilih opsi: ");

                        string pilihan = Console.ReadLine();

                        switch (pilihan)
                        {
                            case "1":
                                statusPerusahaanMachine.MulaiRegistrasi();
                                break;
                            case "2":
                                Console.WriteLine("Masukkan nama perusahaan yang akan disetujui: ");
                                string namaPerusahaanSetujui = Console.ReadLine();
                                statusPerusahaanMachine.SetujuiPerusahaan(namaPerusahaanSetujui);
                                break;
                            case "3":
                                Console.WriteLine("Masukkan nama perusahaan yang akan ditolak: ");
                                string namaPerusahaanTolak = Console.ReadLine();
                                statusPerusahaanMachine.TolakPerusahaan(namaPerusahaanTolak);
                                break;
                            case "4":
                                statusPerusahaanMachine.TunjukkanStatusRegistrasi();
                                break;
                            case "5":
                                statusPerusahaanMachine.ResetSemuaStatus();
                                break;
                            case "0":
                                kelolaBerjalan = false;
                                break;
                            default:
                                Console.WriteLine("Opsi tidak valid. Silakan pilih lagi.");
                                break;
                        }
                    }
                }
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Tambah Pekerjaan dan Gaji");
                Console.WriteLine("4. Kelola Status Registrasi Perusahaan");
                Console.WriteLine("0. Keluar");
                input = Console.ReadLine();
            }
        }
        public static void automataTesting()
        {
            StatusPekerja statusPekerja= new StatusPekerja();
            Pekerja pekerja1 = new Pekerja();

            Lamaran lamaran = new Lamaran(pekerja1.idPekerja, "PR1392324");
            lamaran.statusLamaran = "ditolak";
            pekerja1.lamaranDikirim.Add(lamaran);
            lamaran.statusLamaran = "ditolak";
            pekerja1.lamaranDikirim.Add(lamaran);
            lamaran.statusLamaran = "diterima";
            pekerja1.lamaranDikirim.Add(lamaran);
            statusPekerja.ProcessChar(pekerja1.lamaranDikirim);
        }
        public static void inputLokasiPerusahaan()
        {
            int i = 1;
            Lokasi lokasi= new Lokasi();
            Console.WriteLine("Provinsi: ");
            foreach (string lokasiPerusahaan in Enum.GetNames(typeof(Lokasi.Provinsi)))
            {
                Console.WriteLine(i+". "+lokasiPerusahaan);
                i++;
            }
            Console.WriteLine("Pilih provinsi perusahaan anda berasal:");
            int inputProvinsi = Convert.ToInt32(Console.ReadLine());
            int j = 1;
            Console.WriteLine("Kota: ");
            foreach (string kota in Lokasi.getKota(inputProvinsi-1))
            {
                Console.WriteLine(j + ". " + kota);
                j++;
            }
            Console.WriteLine("Pilih kota perusahaan anda berasal:");
            int inputKota = Convert.ToInt32(Console.ReadLine());
            Perusahaan perusahaan = new Perusahaan();
            perusahaan.lokasi = new int[] { inputProvinsi-1, inputKota-1 };
            Console.WriteLine("Perusahaan anda berada di Provinsi "+ Enum.GetName(typeof(Lokasi.Provinsi), inputProvinsi - 1) + " kota "+ Lokasi.getKota(inputProvinsi - 1)[inputKota-1]);
        }
    }
}
