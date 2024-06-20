using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using TubesKPL_WorkersUnion;

public enum StatusPerusahaan
{
    MemasukkanInfoPerusahaan,
    Disetujui,
    Ditolak
}
public enum State { unemployed, searching, employed }

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
    public string profilPerusahaan { get; set; }
    public List<Pekerjaan> postinganPekerjaan { get; set; }
    public int[] lokasi {  get; set; }
    public string Nama { get; set; }
    public string Email { get; set; }
    public string NomorTelepon { get; set; }
    public string Deskripsi { get; set; }
    public StatusPerusahaan Status { get; set; }
    public Perusahaan()
    {
        Random rnd = new Random();
        this.idPerusahaan = "PR" + rnd.Next(1000000, 2000000).ToString();
        this.rating = 0;
        this.jumlahEmployee = 0;
        this.postinganPekerjaan = new List<Pekerjaan>();
        this.lokasi = new int[2];
        this.lokasi[0]=-1;
        this.lokasi[1]=-1;
        this.Nama = "";
        this.Email = "";
        this.NomorTelepon = "";
        this.Deskripsi = "";
        this.Status = StatusPerusahaan.Ditolak;
    }
    public void TambahDataPerusahaan(string nama, string email, string nomorTelepon, string deskripsi)
    {
        this.Nama = nama;
        this.Email = email;
        this.NomorTelepon = nomorTelepon;
        this.Deskripsi = deskripsi;
    }
}
public class Pekerja
{
    public string idPekerja { get; set; }
    public string profilPekerja { get; set; }
    public string tanggalLahir {  get; set; }
    public string noTelepon {  get; set; }
    public List<Lamaran> lamaranDikirim { get; set; }
    public CV Cv { get; set; }
    public State Status { get; set; }
    public Pekerja()
    {
        Random rnd = new Random();
        this.idPekerja = "PK" + rnd.Next(1000000, 2000000).ToString();
        this.Cv = new CV();
        this.lamaranDikirim = new List<Lamaran>();
        this.Status = State.unemployed;
        this.tanggalLahir = "";
        this.noTelepon = "";
    }
}

public class Lamaran
{
    public string idLamaran {  get; set; }
    public string idPekerja { get; set; }
    public string idPekerjaan { get; set; }
    public string idCv { get; set; }
    public string jawaban {  get; set; }
    public string statusLamaran { get; set; }
    public Lamaran(){}
}

public class Pekerjaan
{
    public string idPekerjaan { get; set; }
    public string idPerusahaan { get; set; }
    public string judulPekerjaan { get; set; }
    public int[] lokasi { get; set; }
    public string gaji { get;set; }
    public string deskripsiPekerjaan { get; set; }
    public List<Lamaran> lamaranDiterima { get; set; }
    public string pertanyaan { get; set; }
    public Pekerjaan()
    {
        this.lamaranDiterima = new List<Lamaran>();
    }
}

public class CV
{
    public string idCv {  get; set; }
    public string riwayatPendidikan { get; set; }
    public string riwayatPekerjaan { get; set; }
    public string skill {  get; set; }
    public string idPekerja {  get; set; }
    public CV(){}
}

public class Config
{
    public List<Pengguna> pengguna { get; set; }
    public Config()
    {
        this.pengguna = new List<Pengguna>();
    }
}
public class Verifikasi_Config
{
    public List<Verifikasi> verifikasi { get; set; }
    public Verifikasi_Config()
    {
        this.verifikasi = new List<Verifikasi>();
    }
}
public class Verifikasi
{
    public string idPerusahaan { get; set; }
    public string kategoriPerusahaan { get; set; }
    public string tanggalPerusahaan { get; set; }
    public string asetPerusahaan { get; set; }
    public string alamatPerusahaan { get; set; }
    public Verifikasi(string idPerusahaan)
    {
        this.idPerusahaan=idPerusahaan;
    }
    public void tambahDataVerifikasi(string kategori, string tanggal, string aset, string alamat)
    {
        this.kategoriPerusahaan = kategori;
        this.tanggalPerusahaan =tanggal;
        this.asetPerusahaan=aset;
        this.alamatPerusahaan=alamat;
    }
}