using System;

namespace Fussball_Simulator
{
    internal class Program
    {
        Random random = new Random();
        static void Main(string[] args)
        {
            
            // Mannschaft 1
            Trainer trainer1 = new Trainer("Juergen Klinsmann", 34, 9);
            Torwart torwart1 = new Torwart("J. Lehmann", 36, 8, 1, 9, 7);
            Spieler[] spieler1 = new Spieler[10];
            spieler1[0] = new Spieler("P. Lahm", 23, 9, 5, 9);
            spieler1[1] = new Spieler("C. Metzelder", 25, 8, 2, 7);
            spieler1[2] = new Spieler("P. Mertesacker", 22, 9, 2, 8);
            spieler1[3] = new Spieler("M. Ballack", 29, 7, 5, 8);
            spieler1[4] = new Spieler("T. Borowski", 26, 9, 8, 9);
            spieler1[5] = new Spieler("D. Odonkor", 22, 7, 5, 8);
            spieler1[6] = new Spieler("B. Schweinsteiger", 22, 2, 3, 2);
            spieler1[7] = new Spieler("L. Podolski", 21, 7, 8, 9);
            spieler1[8] = new Spieler("M. Klose", 28, 10, 9, 7);
            spieler1[9] = new Spieler("O. Neuville", 33, 8, 8, 7);
            Mannschaft m1 = new Mannschaft("Deutschland WM 2006", trainer1, torwart1, spieler1);

            // Mannschaft 2
            Trainer trainer2 = new Trainer("Carlos Alberto Parreira", 50, 3);
            Torwart torwart2 = new Torwart("Dida", 25, 9, 1, 6, 8);
            Spieler[] spieler2 = new Spieler[10];
            spieler2[0] = new Spieler("Cafu", 33, 8, 4, 6);
            spieler2[1] = new Spieler("R. Carlos", 32, 9, 9, 2);
            spieler2[2] = new Spieler("Lucio", 29, 10, 9, 9);
            spieler2[3] = new Spieler("Ronaldinho", 25, 10, 9, 5);
            spieler2[4] = new Spieler("Zé Roberto", 27, 7, 7, 4);
            spieler2[5] = new Spieler("Kaká", 22, 10, 8, 10);
            spieler2[6] = new Spieler("Juninho", 26, 7, 10, 3);
            spieler2[7] = new Spieler("Adriano", 23, 8, 8, 4);
            spieler2[8] = new Spieler("Robinho", 19, 9, 8, 9);
            spieler2[9] = new Spieler("Ronaldo", 28, 4, 10, 2);
            Mannschaft m2 = new Mannschaft("Brasilien WM 2006", trainer2, torwart2, spieler2);


            Spiel spiel = new Spiel();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Start des Spiels zwischen");
            Console.WriteLine();
            Console.WriteLine(m1.GetName());
            Console.WriteLine(" Trainer: " + m1.GetTrainer().GetName());
            Console.WriteLine();
            Console.WriteLine(" und");
            Console.WriteLine();
            Console.WriteLine(m2.GetName());
            Console.WriteLine(" Trainer: " + m2.GetTrainer().GetName());
            Console.WriteLine("-----------------------------------");
            spiel.StarteSpiel(m1, m2);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(spiel.GetErgebnisText());
            Console.WriteLine("-----------------------------------");


        }
        
    }
}
