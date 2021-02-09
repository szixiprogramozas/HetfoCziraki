using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace megfejtes
{

    class Program
    {
        static char[,] rejtveny;
        static List<string> rejtvenyszo = new List<string>();
        static List<string> szavak = new List<string>();

        static void Main(string[] args)
        {
            const string eleresiut = @"rejtveny.txt";
            const string szavakut = @"szavak.txt";

            Console.WriteLine("1. feladat:");
            Elso(eleresiut);

            Console.WriteLine("\n2. feladat:");
            Masodik(szavakut);

            Console.ReadKey();
        }

        static void Elso(string eleresiut)
        {
            StreamReader fajl = new StreamReader(eleresiut);
            string sor = "";
            int index = -1;

            while ((sor = fajl.ReadLine()) != null)
            {
                if (index == -1)
                {
                    string[] temp = sor.Split(' ');

                    rejtveny = new char[int.Parse(temp[0]), int.Parse(temp[1])];
                }
                else
                {
                    char[] temp = sor.ToCharArray();
                    string[] temp2 = sor.Split('X');

                    for (int i = 0; i < temp2.Length; i++)
                    {
                        if (temp2[i] != "" && temp2[i] != " ")
                        {
                            rejtvenyszo.Add(temp2[i]);
                        }
                    }

                    for (int i = 0; i < temp.Length; i++)
                    {
                        rejtveny[index, i] = temp[i];
                    }
                }

                index++;
            }

            for (int i = 0; i < rejtveny.GetLength(0); i++)
            {
                for (int j = 0; j < rejtveny.GetLength(1); j++)
                {
                    if (rejtveny[i, j] == 'X')
                    {
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write(rejtveny[i, j]);
                    }
                }

                Console.WriteLine();
            }
        }

        static void Masodik(string eleresiut)
        {
            StreamReader fajl = new StreamReader(eleresiut);
            string sor = "";

            while ((sor = fajl.ReadLine()) != null)
            {
                szavak.Add(sor);
            }

            foreach (string szo in szavak)
            {
                Console.WriteLine(szo);
            }
        }

        static void Harmadik()
        {

        }

        static void Negyedik()
        {

        }

        static void Otodik()
        {

        }

        static void Hatodik()
        {

        }

        static void Hetedik()
        {

        }

        static void Nyolcadik()
        {

        }
    }
}