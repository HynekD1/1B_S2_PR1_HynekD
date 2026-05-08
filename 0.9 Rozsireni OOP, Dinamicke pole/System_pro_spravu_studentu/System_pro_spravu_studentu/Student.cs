using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_pro_spravu_studentu
{
    public enum Grade
    {
        A1,
        A2,
        A3,
        A4,
        B1,
        B2,
        B3,
        B4
    }
    internal class Student
    {
        Random rnd = new Random();
        public string Name { get; set; }
        public  int Age { get; set; }
        public Grade Grade { get; set; }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Jméno:{this.Name} věk:{this.Age}, třída:{this.Grade}");
        }

        public Student()
        {
            string[] Names = new string[]
            {
                "Adam",
                "Benjamin",
                "Cyril",
                "David",
                "Erik",
                "Filip",
                "Gabriel",
                "Hynek",
                "Ivan",
                "Jakub",
                "Karel",
                "Lukáš",
                "Matěj",
                "Nikolas",
                "Ondřej",
                "Patrik",
                "Radek",
                "Samuel",
                "Tomáš",
                "Viktor",
                "Zdeněk",
                "Aleš",
                "Bohdan",
                "Ctibor",
                "Dominik",
                "Emil",
                "František",
                "Gustav",
                "Herbert",
                "Igor",
                "Josef",
                "Kryštof",
                "Libor",
                "Marek",
                "Norbert",
                "Oskar",
                "Pavel",
                "Richard",
                "Stanislav",
                "Václav",
                "Zoran",
                "Adriana",
                "Barbora",
                "Cecilie",
                "Denisa",
                "Eliška",
                "Hana",
                "Klára",
                "Monika"
            };
            this.Name = Names[rnd.Next(0, Names.Length - 1)];
            this.Age = rnd.Next(14, 20);
            this.Grade = (Grade)rnd.Next(0,8); 
        }
        


    }
}
