using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CA210216
{
    internal static class Program
    {
        private static readonly List<Lama> Lamak = new List<Lama>(); // Lámák listája
        
        public static void Main()
        {
            // 'LAMA' feladatsor, Zvolenszki Benjámin 11.B, 2021. 02. 16.
            // Console App rész

            LamakBeolvasasa("..\\..\\..\\Res\\lama.txt"); // Listába olvasás
            
            Console.WriteLine($"F1: Összesen {Lamak.Count} láma van a listában."); // 1. feladat
            Console.WriteLine(Feladat3()); // 3. feladat
            Console.WriteLine($"F4: {Feladat4()} ízt kedvelő lámák vannak többen."); // 4. feladat
            Console.WriteLine($"F5: Összesen {Feladat5()} db szóköz van a lámák neveiben."); // 5. feladat

            Feladat6("stat.txt");
        }

        private static void Feladat6(string statTxt)
        {
            var edesAtlagEletkor = // Átlag életkor számolása
                Math.Round(
                    Lamak.Where(
                        lama => lama.KedvencIz == Lama.Izek.Edes)
                        .Average(lama => lama.Eletkor), 1); // Egy tizedesjegy pontossággal
            var sosAtlagEletkor =
                Math.Round(
                    Lamak.Where(
                        lama => lama.KedvencIz == Lama.Izek.Sos)
                        .Average(lama => lama.Eletkor), 1);

            using (var writer = new StreamWriter(statTxt))
                writer.WriteLine($"édes ízt kedvelők átlagéletkora: {edesAtlagEletkor}\n" +
                                 $"sós ízt kedvelők átlagéletkora: {sosAtlagEletkor}");
        }
        
        private static int Feladat5() => Lamak.Sum(lama => lama.Nev.Count(c => c == ' ')); // Szóközök
                                                                                                     // megszámolása

        private static string Feladat4() =>
            Lamak.Count(lama => lama.KedvencIz == Lama.Izek.Edes) > // Édes ízt kedvelő lámák megszámolása
            Lamak.Count(lama => lama.KedvencIz == Lama.Izek.Sos) // Sós ízt kedvelő lámák megszámolása
                ? "Az édes"                                      // --> melyikből van több?
                : "A sós";

        private static string Feladat3()
        {
            var oldestLama = Lamak.Find(
                lama => lama.Eletkor == Lamak.Max(lama1 => lama1.Eletkor)); // Legöregebb láma megkeresése
            return $"F3: A legöregebb {oldestLama.Nev}, ő {oldestLama.Eletkor} éves.";
        }
        
        private static void LamakBeolvasasa(string lamaTxt)
        {
            using (var reader = new StreamReader(lamaTxt, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    var dataParts = reader.ReadLine()?.Split(';'); // Sor beolvasása
                    if (dataParts != null)
                        Lamak.Add(new Lama(dataParts[0], // Név
                            Convert.ToUInt16(dataParts[1]), // Születési év
                            dataParts[2] == "édes" // Kedvenc íz
                                ? Lama.Izek.Edes
                                : Lama.Izek.Sos));
                }
            }
        }
    }
}