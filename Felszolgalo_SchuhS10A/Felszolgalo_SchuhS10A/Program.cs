using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felszolgalo_SchuhS10A
{
    class Program
    {
        static string[] FelszolgaloNevTMb = new string[21];
        static int[] BevetelTMB = new int[21];
        static int[] TanyerokTMB = new int[21];
        static int[] BorravaloTMB = new int[21];
        static int[] EgyenlegTMB = new int[21];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1(); Console.WriteLine("\n-------------------------------------------\n");
            Feladat2(); Console.WriteLine("\n-------------------------------------------\n");
            Feladat3(); Console.WriteLine("\n-------------------------------------------\n");
            Feladat4(); Console.WriteLine("\n-------------------------------------------\n");
            Feladat5(); Console.WriteLine("\n-------------------------------------------\n");
            Feladat6(); Console.WriteLine("\n-------------------------------------------\n");
            Feladat7();
            Console.ReadKey();
        }

        private static void Feladat7()
        {
            Console.WriteLine("7.Feladat: Keresési tétel");
            Console.Write("\tKérem adja meg a felszolgáló nevét: ");
            string KeresettNev = Console.ReadLine().ToLower().Replace(" ","");
            int Szamlalo = 0;
            while (Szamlalo<FelszolgaloNevTMb.Length && KeresettNev!=FelszolgaloNevTMb[Szamlalo].ToLower().Replace(" ", ""))
            {
                Szamlalo++;
            }
            if(Szamlalo==FelszolgaloNevTMb.Length)
            {
                Console.WriteLine("\tNincs ilyen felszolgáló");
            }
            else
            {
                Console.WriteLine("\tKeresett felszolgáló : {0}", FelszolgaloNevTMb[Szamlalo]);
                Console.WriteLine("\tBevétel: {0}",BevetelTMB[Szamlalo]);
                Console.WriteLine("\tEnnyi tányért tört el: {0}", TanyerokTMB[Szamlalo]);
                Console.WriteLine("\tEnnyi volt az eredménye: {0}", EgyenlegTMB[Szamlalo]);
            }
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat: Hányan kaptak 32 vagy a fölötti borrabalót");
            int db = 0;
            for (int i = 0; i < BorravaloTMB.Length; i++)
            {
                if(BorravaloTMB[i]>=32)
                {
                    db++;
                }
            }
            Console.WriteLine("\tEnnyi alkalommal volt 32 peták feletti a borravaló: {0}", db);
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat: Borravaló átlaga");
            double OsszesBorravalo = 0;
            double AtlagBorravalo = 0;
            for (int i = 0; i < BorravaloTMB.Length; i++)
            {
                OsszesBorravalo += BorravaloTMB[i];
            }
            AtlagBorravalo = OsszesBorravalo / BorravaloTMB.Length;
            Console.WriteLine("\tA borravalók átlaga: {0:0.00} peták", AtlagBorravalo);
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat minimum, maximum kiválasztás");
            int MaxBevetel = int.MinValue;
            int MinBevetel = int.MaxValue;
            string MaxNev = "cica";
            string MinNev = "kutya";
            for (int i = 0; i < BevetelTMB.Length; i++)
            {
                if(MaxBevetel<BevetelTMB[i])
                {
                    MaxBevetel = BevetelTMB[i];
                    MaxNev = FelszolgaloNevTMb[i];
                }
                if(BevetelTMB[i]<MinBevetel)
                {
                    MinBevetel = BevetelTMB[i];
                    MinNev = FelszolgaloNevTMb[i];
                }
            }
            Console.WriteLine("\tA legtöbb bevételt : {0} ",MaxNev);
            Console.WriteLine("\tA legtöbb bevétel: {0} peták", MaxBevetel);
            Console.WriteLine("\tA legkevesebb bevételt : {0} ", MinNev);
            Console.WriteLine("\tA legkevesebb bevétel: {0} peták", MinBevetel);
            Console.WriteLine("\tA bevételek legnagyobb különbsége: {0}", MaxBevetel-MinBevetel);
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: Egyenleg számítás");
            int Egyenleg=0;
            for (int i = 0; i < BevetelTMB.Length; i++)
            {
                Egyenleg = BevetelTMB[i] - TanyerokTMB[i] * 10 + BorravaloTMB[i];
                EgyenlegTMB[i] = Egyenleg;
                //EgyenlegTMB[i] =BevetelTMB[i] - TanyerokTMB[i] * 10 + BorravaloTMB[i];
            }
            for (int i = 0; i < EgyenlegTMB.Length; i++)
            {
                Console.WriteLine("\t{0,-25} -> {1}",FelszolgaloNevTMb[i], EgyenlegTMB[i]);
            }

        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: Kiíratas");
            for (int i = 0; i < FelszolgaloNevTMb.Length; i++)
            {
                Console.WriteLine("\t{0,-25} -> bevétel: {1:000} --> tanyér: {2:00} ---> borravalo: {3:00}", FelszolgaloNevTMb[i], BevetelTMB[i], TanyerokTMB[i], BorravaloTMB[i]);
            }
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: Adatok felvitele");
            FelszolgaloNevTMb = new string[21] { "Lacey-Mai Calhoun", "Taliah Sheldon", "Debra Mcfarland", "Blessing Powers", "Kelise Carson", "Courteney Lambert", "Alanna Dodson", "Affan O'Gallagher", "Rhyley Curtis", "Kathy Rosas", "Laiba Chang", "Dillan Meadows", "Bernice Kaiser", "Brax Hahn", "Malaki Grey", "Penelope Mayo", "Hebe Davila", "Iain Diaz", "Shayna Gay", "Jaxx Macgregor", "Maddy Porter" };
            BevetelTMB = new int[21] { 230, 238, 148, 131, 122, 153, 249, 133, 224, 175, 245, 118, 160, 205, 187, 171, 123, 223, 155, 116, 210 };
            BorravaloTMB = new int[21] { 35, 12, 35, 19, 20, 16, 23, 29, 42, 21, 12, 29, 32, 19, 49, 14, 11, 15, 34, 39, 24 };
            int Tanyer;
            for (int i = 0; i < TanyerokTMB.Length; i++)
            {
                Tanyer = rnd.Next(2, 12);
                TanyerokTMB[i] = Tanyer;
            }
        }
    }
}
