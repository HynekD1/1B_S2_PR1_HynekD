using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapouzdreni
{
    internal class Predmet
    {
        //soukromá vlastnost - nelze nastavit mimo třídu
        private int price;
        private double weight;
        private double wood; //z kolika procet je to dřevený? Budeme ukládat 0 až 100%

        //Veřejná položka - short-had (zkrácený zápis
        public string Name { get; set; }//Skoukromá položka nejde vydět ale dodržuje se princip zapouzdrení
        

        //Nastavit hodnoutu mohu jen ve třídě, ale zobrazit mohu kdekoliv
        public int ID { get; private set; }

        //konstruktor
        public Predmet()
        {

            this.ID = 100;
        }



        //Verejnou položka pro nastavení hodnoty soukromé vlastnosti
        public int Price
        {

            get
            {
                return price;
            }
            set
            {
                price = value; 
                //value je hodnota, kterou se zadává při předpisu Price.
                //V mainu to může vypadat: objekt.Price = 4 (value je pak 4)
            }
        }


        //Veřejná podmínka s podmínkou settru
        public double Weight
        {
            get
            {
                return weight;
            }
            //Aby se nestalo, že se uloží nesmyslná váha, tak má setter podmínku
            //Váha musí být kladná
            set
            {
                if (value >= 0)
                {
                    weight = value;

                }

            }
        }

        //Veřejná položka
        public double Wood
        {
            get
            {
                return wood;
            }
            set
            {
                //Hodnoty v rozmezí 0-100, pokud přestřelí uloží se nejvyšší, neboli 100%
                if (value < 0)
                {
                    wood = 0;
                }else if(value > 100)
                {
                    wood = 100;
                }
                else
                {
                    wood = value;
                }
            }
        }

        /* Nastavení soukromé položky podle samostatné vytvoření metod
        public int GetPrice()
        {
            return prive;
        }

        public void SetPrice(int newPrice)
        {
            this.prive = newPrice;
        }

        */


    }
}
