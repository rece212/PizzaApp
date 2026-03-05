using System;
using System.Collections.Generic;
using System.Text;

namespace prjPizzaApp
{
    public abstract class Pizza
    {
        public abstract String Name { get; set; }
        public abstract String Cheese { get; set; }    

        private string strBase = "wheat";
        private string strSurce = "Tomato";
        private string strToppings = "";
        public void getToppings()
        {
            strToppings = "Toppings :Plain Pizza with nothing else\n";
        }
        public void getToppings(String topping)
        {
            strToppings = "Toppings :"+topping+"\n";
        }
        public void getToppings(String topping,string topping2)
        {
            strToppings = "Toppings :" + topping + " and " + topping2 + "\n";
        }

        public override string ToString()
        {
            return strToppings + " with " + strSurce + " and the base is " +
                strBase;
        }
    }
}
