using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolni_system
{
    internal class Student
    {
        private string jmeno;
        private int ID;
        private Znamka[] znamky;

        public Student(int id, bool gen, string jmeno = "")
        {
            string[] jmena = new string[]
                    {
                        "Adam", "Alex", "Alice", "Andrea", "Antonín",
                        "Barbora", "Bedřich", "Blanka", "Bohdan", "Bohumil",
                        "Cecilie", "Cyril", "Ctibor", "Ctirad", "Dalibor",
                        "Daniel", "Denisa", "Dominik", "Drahomír", "Dušan",
                        "Eliška", "Emil", "Erik", "Eva", "František",
                        "Gabriela", "Gustav", "Hana", "Helena", "Hynek",
                        "Ivan", "Ivana", "Ivo", "Izabela", "Jana",
                        "Jan", "Jaroslav", "Jindřich", "Jiří", "Johana",
                        "Kamila", "Karel", "Karolína", "Klára", "Kryštof",
                        "Ladislav", "Laura", "Libor", "Lucie", "Ludmila",
                        "Magdaléna", "Matěj", "Martin", "Markéta", "Marek",
                        "Milan", "Miloslav", "Miroslav", "Monika", "Natálie",
                        "Nela", "Nikolas", "Nikol", "Norbert", "Oldřich",
                        "Olga", "Oskar", "Otakar", "Patrik", "Pavel",
                        "Petr", "Radek", "Radim", "Renata", "Richard",
                        "Robert", "Romana", "Roman", "Rostislav", "Sabina",
                        "Samuel", "Simona", "Slavomír", "Soňa", "Stanislav",
                        "Šárka", "Šimon", "Tadeáš", "Tamara", "Tomáš",
                        "Václav", "Veronika", "Viktor", "Vilém", "Zdeněk"
                    };

            this.ID = id;
            if (gen)
            {
                Random rnd = new Random();
                this.jmeno = jmena[rnd.Next(0, jmena.Length)];
            }
            else
            {
                this.jmeno = jmeno;
            }

            this.znamky = new Znamka[0];

        }

        public void PredstavSe()
        {
            Console.WriteLine($"Student {this.jmeno} s ID: {this.ID}");
        }

        public void PridejZnamku(int znamka, int vaha, string predmet)
        {
            Array.Resize(ref this.znamky, this.znamky.Length + 1);
            znamky[znamky.Length - 1] = new Znamka(znamka, vaha, predmet);
        }

        public void VypisZnamky()
        {
            for (int i = 0; i < this.znamky.Length; i++)
            {
                Console.WriteLine(this.znamky[i].VratZnamku());
            }
        }

    }
}