using System;

class RadarProgram
{
    static void Main(string[] args)
    {
        // 1. DATA JSOU UVNITŘ MAIN
        int velikostMapy = 15;
        int letisteX = 7;
        int letisteY = 7;
        int skore = 0;
        bool hraBezi = true;

        string[] letKod = { "OK-123", "RY-456", "LH-789", "", "" };
        int[] letX = { 2, 12, 7, 0, 0 };
        int[] letY = { 2, 4, 14, 0, 0 };
        int[] letVyska = { 4, 2, 1, 0, 0 }; // 0 = prázdný slot
        string[] letSmer = { "Jih", "Zapad", "Sever", "", "" };
        int[] letPalivo = { 15, 20, 5, 0, 0 };

        while (hraBezi)
        {
            // PŘEDÁVÁME POLE DO METOD
            VykresliRadar(velikostMapy, letisteX, letisteY, letX, letY, letVyska);
            VypisTabulku(letKod, letX, letY, letVyska, letSmer, letPalivo);

            Console.WriteLine($"\nSKÓRE: {skore} | 1. Příkaz | 2. Další tah");
            Console.Write("Volba: ");
            string volba = Console.ReadLine();

            if (volba == "1")
            {
                ZadejPrikaz(letSmer, letVyska, letKod);
            }
            else if (volba == "2")
            {
                // ref u skore umožňuje metodě měnit hodnotu proměnné v Main
                hraBezi = ProvedTah(letX, letY, letVyska, letSmer, letPalivo, letisteX, letisteY, ref skore, velikostMapy, letKod);
            }
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nKONEC HRY! Konečné skóre: {skore}");
        Console.ResetColor();
    }

    // --- METODA PRO RADAR S BARVAMI ---
    static void VykresliRadar(int velikost, int lx, int ly, int[] xP, int[] yP, int[] vP)
    {
        Console.Clear();
        for (int y = 0; y < velikost; y++)
        {
            for (int x = 0; x < velikost; x++)
            {
                if (x == lx && y == ly)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" X ");
                }
                else
                {
                    int id = -1;
                    for (int i = 0; i < xP.Length; i++)
                        if (vP[i] > 0 && xP[i] == x && yP[i] == y) id = i;

                    if (id != -1)
                    {
                        // BARVA PODLE VÝŠKY
                        if (vP[id] >= 4) Console.ForegroundColor = ConsoleColor.Cyan; // Vysoko
                        else if (vP[id] >= 2) Console.ForegroundColor = ConsoleColor.Yellow; // Klesá
                        else Console.ForegroundColor = ConsoleColor.Green; // Přistává

                        Console.Write($" {id} ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" . ");
                    }
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    // --- METODA PRO TABULKU S VAROVÁNÍM ---
    static void VypisTabulku(string[] kody, int[] x, int[] y, int[] vysky, string[] smery, int[] paliva)
    {
        Console.WriteLine("\nID | LET       | POZICE  | VÝŠKA | SMĚR   | PALIVO");
        Console.WriteLine("--------------------------------------------------");
        for (int i = 0; i < kody.Length; i++)
        {
            if (vysky[i] > 0)
            {
                // ČERVENÁ POKUD DOCHÁZÍ PALIVO
                if (paliva[i] <= 3) Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"{i}  | {kody[i],-9} | [{x[i],2},{y[i],2}] | {vysky[i]}     | {smery[i],-6} | {paliva[i]}j.");
                Console.ResetColor();
            }
        }
    }

    static void ZadejPrikaz(string[] smery, int[] vysky, string[] kody)
    {
        Console.Write("Zadej ID letadla: ");
        if (int.TryParse(Console.ReadLine(), out int id) && id >= 0 && id < kody.Length && vysky[id] > 0)
        {
            Console.Write("Změnit (S)měr nebo (V)ýšku? ");
            string volba = Console.ReadLine().ToUpper();
            if (volba == "S")
            {
                Console.Write("Nový směr (Sever, Jih, Vychod, Zapad): ");
                smery[id] = Console.ReadLine();
            }
            else
            {
                Console.Write("Nová výška (1-5): ");
                vysky[id] = int.Parse(Console.ReadLine());
            }
        }
        else Console.WriteLine("Neplatné ID!");
    }

    static bool ProvedTah(int[] x, int[] y, int[] v, string[] s, int[] p, int lx, int ly, ref int skore, int map, string[] kody)
    {
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] == 0) continue;

            // POHYB
            if (s[i] == "Sever") y[i]--;
            else if (s[i] == "Jih") y[i]++;
            else if (s[i] == "Vychod") x[i]++;
            else if (s[i] == "Zapad") x[i]--;

            p[i]--;

            // KONTROLA PŘISTÁNÍ (Vektor Sever + Výška 1)
            if (x[i] == lx && y[i] == ly)
            {
                if (v[i] == 1 && s[i] == "Sever")
                {
                    v[i] = 0; // Letadlo zmizí (přistálo)
                    skore++;
                    Console.Beep(); // Malý zvukový efekt
                    continue;
                }
            }

            // PROHRA (Hranice nebo palivo)
            if (x[i] < 0 || x[i] >= map || y[i] < 0 || y[i] >= map || p[i] <= 0)
            {
                Console.WriteLine($"\nHAVÁRIE letadla {kody[i]}, Vybouchlo!");
                return false;
            }
        }
        return true;
    }
}