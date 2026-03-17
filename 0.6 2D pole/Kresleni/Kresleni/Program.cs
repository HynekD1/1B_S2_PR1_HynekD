namespace Kresleni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] mapa =
        {
            {  true, false, false,  true, false, false,  true},
            { false,  true, false,  true, false,  true, false},
            { false, false,  true,  true,  true, false, false},
            { false, false, false,  true, false, false, false},
        };

            VykresliPole(mapa);
        }
    }
}
