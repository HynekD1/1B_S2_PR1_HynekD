namespace Enum
{
    internal class Program
    {
        enum Obdobi { Jaro, Leto, Podzim, Zima };

        static void Main(string[] args)
        {
            Obdobi sezona = Obdobi.Podzim;
            sezona++;
            Console.WriteLine(sezona);
            sezona++; 
            Console.WriteLine(sezona);

            Console.ReadKey();

            //Console.WriteLine(Planets.Pluto + " je planeta");
            //Console.WriteLine(Planets.Mercur + " je planeta" + (int)Planets.Mercur);
            //Console.WriteLine(Planets.Pluto + " je planeta" + (int)Planets.Venuse);

            string name = PlanetRadius.Zeme.ToString();
            int radius = (int)PlanetRadius.Zeme;
            double volume = Volume(PlanetRadius.Zeme);

            Console.WriteLine($"Planet: {name}");
            Console.WriteLine($"Radius: {radius} km");
            Console.WriteLine($"Volume" );
        }
        public static double Volume (PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }

        enum Planets
        {
            Mercur = 1,
            Venuse,
            Zeme,
            Mars,
            Jupiter,
            Saturn,
            Uran,
            Neptun,
            Pluto
        }

        enum PlanetRadius
        {
            Mercur = 2439,
            Venuse = 54578,
            Zeme = 5485,
            Mars = 52855,
            Jupiter = 7412,
            Saturn = 98554,
            Uran = 8742,
            Neptun = 24564,
            Pluto = 8442
        }

    }
}
