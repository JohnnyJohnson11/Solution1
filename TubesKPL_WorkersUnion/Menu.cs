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
            StatusPerusahaan statusPerusahaan = new StatusPerusahaan();

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
                    while (!valid)
                    {
                        try
                        {
                            if (int.TryParse(password, out _))
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
                    while (true)
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
                                statusPerusahaan.MulaiRegistrasi();
                                break;
                            case "2":
                                statusPerusahaan.SetujuiRegistrasi();
                                break;
                            case "3":
                                statusPerusahaan.TolakRegistrasi();
                                break;
                            case "4":
                                statusPerusahaan.TunjukkanStatusRegistrasi();
                                break;
                            case "5":
                                statusPerusahaan.AturUlang();
                                Console.WriteLine("Semua status perusahaan telah diatur ulang.");
                                break;
                            case "0":
                                return;
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
    }
}
