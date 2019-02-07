using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Odev1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            KartFactory kartFactory = new KartFactory();

            FileStream fs = new FileStream("Kartlar.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter Dosya = new StreamWriter(fs);
            try
            {
                Dosya.Write("5489124357801032" + "Beyza Nur Ozkara" + "12.12.2020");
                Dosya.Write("\n345629014628015" + "Selennur Dilsiz" + "20.07.2023");
                Dosya.Write("\n490278401372867" + "Mine Yaman" + "16.11.2021");
                Dosya.Write("\n5738984682397390" + "Aylin Kaya" + "23.02.2019");
                Dosya.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("sanırım bir sorun var " + ex);
            }

            IKart kart1 = kartFactory.getKart(EKartTipi.mastercard);
            kart1.KartEkle();

            IKart kart2 = kartFactory.getKart(EKartTipi.visa);
            kart2.KartEkle();

            IKart kart3 = kartFactory.getKart(EKartTipi.americanexpress);
            kart3.KartEkle();

            Console.ReadLine();
        }
    }
}
