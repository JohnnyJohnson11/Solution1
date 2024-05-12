using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using TubesKPL_WorkersUnion;

namespace TubesKPL_WorkersUnion
{
    public class Pengguna
    {
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public Perusahaan perusahaan { get; set; }
        public Pekerja pekerja { get; set; }
        public Pengguna(string uname, string pword)
        {
            username = uname;
            password = pword;
            perusahaan = new Perusahaan();
            pekerja = new Pekerja();
        }
    }
}

public class Perusahaan
{
    public string idPerusahaan { get; set; }
    public float rating { get; set; }
    public int jumlahEmployee { get; set; }
    public List<Lamaran> lamaranDiterima { get; set; }
    public string profilPerusahaan { get; set; }
    public List<Pekerjaan> postinganPekerjaan { get; set; }
    public Perusahaan()
    {
        Random rnd = new Random();
        idPerusahaan = "PR" + rnd.Next(1000000, 2000000).ToString();
        rating = 0;
        jumlahEmployee = 0;
        lamaranDiterima = new List<Lamaran>();
        postinganPekerjaan = new List<Pekerjaan>();
    }
}
public class Pekerja
{
    public string idPekerja { get; set; }
    public string profilPekerja { get; set; }
    public List<Lamaran> lamaranDikirim { get; set; }
    public Pekerja()
    {
        Random rnd = new Random();
        idPekerja = "PK" + rnd.Next(1000000, 2000000).ToString();
        lamaranDikirim = new List<Lamaran>();
    }
}

public class Lamaran
{
    public string idPekerja { get; set; }
    public string idPerusahaan { get; set; }
    public CV cv { get; set; }
    public string statusLamaran { get; set; }
    public Lamaran(string IdPekerja, string IdPerusahaan)
    {
        idPekerja = IdPekerja;
        idPerusahaan = IdPerusahaan;
    }
}

public class Pekerjaan
{
    public string idPekerjaan { get; set; }
    public string idPerusahaan { get; set; }
    public string deskripsiPekerjaan { get; set; }
    public Pekerjaan(){}
}

public class CV
{
    public string deskripsi { get; set; }
    public CV(string Deskripsi)
    {
        deskripsi = Deskripsi;
    }
}

public class Config
{
    public List<Pengguna> pengguna { get; set; }
    public Config()
    {
        pengguna = new List<Pengguna>();
    }
}

