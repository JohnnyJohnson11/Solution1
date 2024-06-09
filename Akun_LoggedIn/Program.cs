// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;
using System;
using System.Threading;
using System.Text;
using UtilityLibraries;

namespace UtilityLibraries
{
    public class Logged_In
    {
        private Logged_In() { }
        private static Logged_In  _instance;
        private static Logged_In tempInstance;
        private static readonly object _lock = new object();
        public static Logged_In ResetInstance(string idPerusahaan, string idPekerja)
        {
            tempInstance = new Logged_In();
            tempInstance.idPekerja = idPekerja;
            tempInstance.idPerusahaan = idPerusahaan;
            _instance = tempInstance;
            return _instance;
        }
        public static Logged_In GetInstance(string idPerusahaan, string idPekerja)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logged_In();
                        _instance.idPerusahaan = idPerusahaan;
                        _instance.idPerusahaan = idPekerja;
                    }
                }
            }
            return _instance;
        }
        public string idPerusahaan { get; set; }
        public string idPekerja { get; set; }
    }
}
