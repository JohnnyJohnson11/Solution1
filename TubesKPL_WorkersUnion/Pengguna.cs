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
        public Pengguna(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.perusahaan = new Perusahaan();
            this.pekerja = new Pekerja();
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
    public int[] lokasi {  get; set; }
    public Perusahaan()
    {
        Random rnd = new Random();
        this.idPerusahaan = "PR" + rnd.Next(1000000, 2000000).ToString();
        this.rating = 0;
        this.jumlahEmployee = 0;
        this.lamaranDiterima = new List<Lamaran>();
        this.postinganPekerjaan = new List<Pekerjaan>();
        this.lokasi = new int[2];
        this.lokasi[0]=-1;
        this.lokasi[1]=-1;
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
        this.idPekerja = "PK" + rnd.Next(1000000, 2000000).ToString();
        this.lamaranDikirim = new List<Lamaran>();
    }
}

public class Lamaran
{
    public string idPekerja { get; set; }
    public string idPerusahaan { get; set; }
    public CV cv { get; set; }
    public string statusLamaran { get; set; }
    public Lamaran(string idPekerja, string idPerusahaan)
    {
        this.idPekerja = idPekerja;
        this.idPerusahaan = idPerusahaan;
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
        this.deskripsi = Deskripsi;
    }
}

public class Config
{
    public List<Pengguna> pengguna { get; set; }
    public Config()
    {
        this.pengguna = new List<Pengguna>();
    }
}

//test123

//test321