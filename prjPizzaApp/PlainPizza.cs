using System;
using System.Collections.Generic;
using System.Text;

namespace prjPizzaApp
{
    public class PlainPizza : Pizza
    {
        public override string Name 
        { 
            get => "Plain pizza with nothing else";
            set => Name = "Plain pizza with nothing else";
        }
        public override string Cheese 
        { 
            get => "";
            set => Cheese = "";
        }
        public string ToString()
        {
            return "Pizza Name:" + Name + "\n" +
                base.ToString() ;
        }
    }
}
