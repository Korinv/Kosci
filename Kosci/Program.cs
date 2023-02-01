using System;

namespace Kosci
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gm = new List<string>();
            gm.Add("1        ");
            gm.Add("2        ");
            gm.Add("3        ");
            gm.Add("4        ");
            gm.Add("5        ");
            gm.Add("6        ");
            gm.Add("SUMA     ");
            gm.Add("Para     ");
            gm.Add("2 Pary   ");
            gm.Add("Trójka   ");
            gm.Add("M. Stritt");
            gm.Add("D. Stritt");
            gm.Add("Full     ");
            gm.Add("Kareta   ");
            gm.Add("Poker    ");
            gm.Add("Szansa   ");
            gm.Add("SUMA     ");
            List<string> players = new List<string>();
            players.Add("Gracz 1  ");
            players.Add("Gracz 2  ");
            players.Add("Gracz 3  ");
            players.Add("Gracz 4  ");
            players.Add("Gracz 5  ");
            players.Add("Gracz 6  ");
            DrawTable(4, gm, players);
        }

        static void DrawTable(int pNum, List<string> gm, List<string> ply)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Concat("┌", String.Concat(Enumerable.Repeat("─────────┬", pNum)), String.Concat(Enumerable.Repeat("─", 9)), "┐"));
            Console.Write("│Kat\\Gracz");

            for (int j = 0; j < pNum; j++)
            {
                Console.Write(String.Concat("│", ply[j]));
            }
            Console.Write("│");
            Console.WriteLine("");
            for (int i = 0; i < 17; i++)
            {
                Console.WriteLine(String.Concat("├", String.Concat(Enumerable.Repeat("─────────┼", pNum)), String.Concat(Enumerable.Repeat("─", 9)), "┤"));
                Console.Write("│");
                Console.Write(gm[i]);
                for (int k = 0; k < pNum; k++)
                {
                    Console.Write("│   000   ");
                }                
                Console.Write("│");
                Console.WriteLine("");
            }

            Console.WriteLine(String.Concat("└", String.Concat(Enumerable.Repeat("─────────┴", pNum)), String.Concat(Enumerable.Repeat("─", 9)), "┘"));
        }
    }
}

