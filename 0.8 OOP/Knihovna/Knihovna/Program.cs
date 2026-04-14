using System; // Potřebujeme pro Console

namespace Knihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] library = new Book[]
            {
                new Book("Lord of the Rings", 9788845292613, "Fantasy"),
                new Book("The Hobbit", 9780547928227, "Fantasy"),
                new Book("Dune", 9780441172719, "Sci-Fi"),
                new Book("Pride and Prejudice", 9781503290563, "Romance"),
                new Book("The Great Gatsby", 9780743273565, "Classic"),
                new Book("The Name of the Wind", 9780756404741, "Fantasy"),
                new Book("The Martian", 9780553418026, "Sci-Fi"),
                new Book("The Girl with the Dragon Tattoo", 9780307454546, "Thriller"),
                new Book("The Shining", 9780307743657, "Horror"),
                new Book("The Alchemist", 9780061122415, "Philosophical Fiction"),
                new Book("Ready Player One", 9780307887443, "Sci-Fi"),
            };


            
            // Volání metod postupně
            library = Pujcka(library);
            VypisDostupneKnihy(library);

            string[] kids = { "Pepa", "Anička" };
            string[] kidsGenre = { "Fantasy", "Sci-Fi" };
            KnihyProDeti(library, kids, kidsGenre);

            

            Console.ReadLine();
        }

        // 1. Metoda na Půjčky
        static Book[] Pujcka(Book[] books)
        {
            Console.WriteLine("\n------ DOSTUPNÉ KNIHY K VÝPŮJČCE ------");
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Available)
                {
                    Console.WriteLine("[" + i + "] " + books[i].IdentifySelf());
                }
            }

            Console.Write("\nZadejte index knihy, kterou si chcete půjčit: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < books.Length)
            {
                if (books[index].Available)
                {
                    books[index].Available = false;
                    Console.WriteLine("Kniha '" + books[index].Title + "' byla úspěšně vypůjčena.");
                }
                else
                {
                    Console.WriteLine("Tato kniha je již půjčená.");
                }
            }
            return books;
        }

        // 2. Metoda na Dostupné Knihy (Zjednodušená verze bez LINQ)
        static void VypisDostupneKnihy(Book[] books)
        {
            bool existujeZanr = false;
            while (!existujeZanr)
            {
                Console.Write("\nZadejte požadovaný žánr: ");
                string zanr = Console.ReadLine();

                // Nejdřív zjistíme, jestli ten žánr v knihovně vůbec je
                foreach (var knihy in books)
                {
                    // .ToLower() zajistí, že nezáleží na velkých/malých písmenech
                    if (knihy.Genre.ToLower() == zanr.ToLower())
                    {
                        existujeZanr = true;
                        break;
                    }
                }

                if (existujeZanr)
                {
                    Console.WriteLine("Dostupné knihy v žánru " + zanr + ":");
                    foreach (var book in books)
                    {
                        if (book.Genre.ToLower() == zanr.ToLower() && book.Available == true)
                        {
                            Console.WriteLine(book.IdentifySelf());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Tento žánr v knihovně nemáme, zkuste to znovu.");
                }
            }
        }

        // 3. Metoda pro doporučení knih dětem
        static void KnihyProDeti(Book[] books, string[] kids, string[] kidsGenre)
        {
            Console.WriteLine("\n--- DOPORUČENÍ PRO DĚTI ---");
            for (int i = 0; i < kids.Length; i++)
            {
                Console.WriteLine("Dítě: " + kids[i] + " (Oblíbený žánr: " + kidsGenre[i] + ")");

                foreach (var book in books)
                {
                    if (book.Genre.ToLower() == kidsGenre[i].ToLower())
                    {
                        Console.WriteLine(" - " + book.Title);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
