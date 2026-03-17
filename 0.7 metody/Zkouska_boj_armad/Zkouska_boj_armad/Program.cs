using System.Linq.Expressions;

namespace Zkouska_boj_armad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string volba = "";
            int body = 100;
            int[] armadaMoje = { 0, 0, 0 };
            int[] armadaEnemy = { 0, 0, 0 };
            Random gen = new Random();
            armadaEnemy[0] = gen.Next(5, 13);
            armadaEnemy[1] = gen.Next(2, 6);
            armadaEnemy[2] = gen.Next(2, 6);

            do
            {
                Console.WriteLine($"Toto je tvoje armáda Pěšáci: {armadaMoje[0]}, Střelci: {armadaMoje[1]}, Jízda: {armadaMoje[2]} ");
                Console.WriteLine($"Máš {body} bodů. Můžes si koupit:");
                Console.WriteLine("Pěšáci(P) = 5 bodů, Střelci(S) = 10 bodů, Jízda(J) = 10 bodů. Pokud nic nechces (N)");

                volba = Console.ReadLine();

                switch (volba)
                {
                    case "P":
                        armadaMoje[0] += 1;
                        body -= 5;
                        break;

                    case "S":
                        armadaMoje[1] += 1;
                        body -= 10;
                        break;

                    case "J":
                        armadaMoje[2] += 1;
                        body -= 10;
                        break;

                    default:
                        Console.WriteLine("Ukončil jsi nákup. Jdeme do boje!" +
                            "S");
                        break;
                }
                if (body <= 0)
                {
                    Console.WriteLine("Došlí bodíky");
                    break;
                }

            } while (volba == "J" && volba != "N" || volba == "S" && volba != "N" || volba == "P" && volba != "N");
            
            while (armadaEnemy[0] > 0 && armadaEnemy[1] > 0 && armadaEnemy[2] > 0 || armadaMoje[0] > 0 && armadaMoje[1] > 0 && armadaMoje[2] > 0)
            {
                Console.WriteLine($"Toto je tvoje armáda Pěšáci: {armadaMoje[0]}, Střelci: {armadaMoje[1]}, Jízda: {armadaMoje[2]} ");
                Console.WriteLine($"Toto je enemy armáda Pěšáci: {armadaEnemy[0]}, Střelci: {armadaEnemy[1]}, Jízda: {armadaEnemy[2]} ");


            }


            Console.WriteLine(UtokPechotyMoje(armadaMoje));
        
        }



        static int UtokPechotyMoje(int[] ArmadaMoje)
        {

        } 

        

    }
}
