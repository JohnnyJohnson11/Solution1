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
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
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
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
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
    }
}
