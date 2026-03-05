using System;
using System.Collections.Generic;
using System.Text;

namespace prjPizzaApp
{

    public class BaconCheesePizzaBannanaPineapple : Pizza
    {
        private String strName = "Bannana, Pineapple, Bacon and Cheese  Pizza";
        private String strCheese = "The yellow stuff";
        public override string Name
        {
            get => strName;
            set => Name = strName;
        }
        public override string Cheese
        {
            get => strCheese;
            set => Cheese = strCheese;
        }

        public BaconCheesePizzaBannanaPineapple()
        {
            base.getToppings("Bannana,Pineapple","Bacon");
        }
        public string ToString()
        {
            return "Pizza Name:"+Name+"\n"+
                base.ToString()+ " with "+ Cheese; 
        }


    }
}
