using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaz_Kolekce
{
    internal class Auto
    {
        //Veřejné vlastnosti
        public int pocetKol;
        public string SPZ;
        public string[] pasazeri; //vlastnost, která je pole (kolekce)

        //Veřejná metoda
        public void PredstavSe()
        {
            Console.WriteLine($"Toto auto má SPZ: {this.SPZ} a má {this.pocetKol} počet kol.");
        }

        public void OdeberKola(int pocetKol)
        {
            //pocetKol je parametr, který je naplněn argumentem, který pošleme do metody
            //this.pocetKol je vlastnost u konkrétního objektu
            this.pocetKol -= pocetKol;

            if (this.pocetKol < 0) //kontrola, aby auto nemělo mínusová kola
            {
                this.pocetKol = 0;
            }
        }

        //Metoda, co vrací jako string všechny pasažéry
        public string VratPasazery()
        {
            string pasazeri = "";
            for (int i = 0; i < this.pasazeri.Length; i++)
            {
                pasazeri += this.pasazeri[i] + " "; //postupně do proměnné pasazeri načítám hodnoty z pole pasazeri
            }
            return pasazeri;
        }

    }
}