using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2617
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan = new Karyawan(182012, "ARIF", 1500000);
            Karyawan karyawan2 = new Karyawan(182013, "RAHMAT", 1000000);


            Console.WriteLine("NIK \t NAMA \t GAJI");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\n KENAIKAN GAJI \n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("NIK \t NAMA \t GAJI");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();
            Console.WriteLine("--------------------------");

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int NIK { get; set; }
        public string NAMA { get; set; }
        public int GAJIBULANAN { get; set; }

        public Karyawan(int NIK, string NAMA, int GAJI)
        {
            this.NIK = NIK;
            this.NAMA = NAMA;

            if (GAJI < 0)
            {
                this.GAJIBULANAN = 0;
            }
            else
            {
                this.GAJIBULANAN = GAJI;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", NIK, NAMA, GAJIBULANAN);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * GAJIBULANAN;
            GAJIBULANAN += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", NIK, NAMA, GAJIBULANAN);
        }
    }
}
