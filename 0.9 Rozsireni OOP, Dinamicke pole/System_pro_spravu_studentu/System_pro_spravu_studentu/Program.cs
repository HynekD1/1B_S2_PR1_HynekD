using System.ComponentModel;

namespace System_pro_spravu_studentu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> skola = new List<Student>();
            for (int i = 0; i < 1000; i++)
            {
                skola.Add(new Student());
            }

            skola[50].IntroduceSelf();

            //Uživatel zadá věk a vypiše to jenom studenty v tom věku
            Console.WriteLine("Zadej věk studenta!!!");
            int vek = int.Parse(Console.ReadLine());
            for (int i = 0; i < skola.Count; i++)
            {
                if (skola[i].Age == vek)
                {
                    skola[i].IntroduceSelf();
                }
            }
            Console.WriteLine("--------------------------------------------------------------------");
            VypisTridy(skola, Grade.A4);
            //Simulace konec roku, neboli všichny 4 posleme pryř a všichni ostatní o jednu výše 
            for (int i = 0; i < skola.Count; i++)
            {
                switch (skola[i].Grade)
                {
                    case Grade.A1:
                        skola[i].Grade = Grade.A2;
                        break;
                    case Grade.B1:
                        skola[i].Grade = Grade.B2;
                        break;
                    case Grade.A2:
                        skola[i].Grade = Grade.A3;
                        break;
                    case Grade.B2:
                        skola[i].Grade = Grade.B3;
                        break;
                    case Grade.A3:
                        skola[i].Grade = Grade.A4;
                        break;
                    case Grade.B3:
                        skola[i].Grade = Grade.B4;
                        break;
                    case Grade.A4:
                        skola.Remove(skola[i]);
                        i--;
                        break;
                    case Grade.B4:
                        skola.Remove(skola[i]);
                        i--;
                        break;
                }

                VypisTridy(skola, Grade.A4);
                 
            }

            static void VypisTridy(List<Student> studenti,Grade grades)
            {
                for (int i = 0; i < studenti.Count; i++)
                {
                    if (studenti[i].Grade == grades)
                    {
                        studenti[i].IntroduceSelf();
                    }
                }
            }
        }
    }
}
