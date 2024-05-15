using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_WorkersUnion
{
    public class AturPekerja
    {
        private List<Pengguna> daftarPengguna;

        public AturPekerja()
        {
            daftarPengguna = new List<Pengguna>();
        }

        public void TambahPengguna(Pengguna pengguna)
        {
            daftarPengguna.Add(pengguna);
        }

        public Pengguna CariPengguna(string username)
        {
            return daftarPengguna.FirstOrDefault(p => p.username == username);
        }

        public void HapusPengguna(string username)
        {
            Pengguna pengguna = CariPengguna(username);
            if (pengguna != null)
            {
                daftarPengguna.Remove(pengguna);
            }
        }

        public void TampilkanSemuaPengguna()
        {
            foreach (var pengguna in daftarPengguna)
            {
                Console.WriteLine($"Username: {pengguna.username}, Full Name: {pengguna.fullname}");
            }
        }
    }
}
