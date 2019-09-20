using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ComponentDecorator.Sauce
{
    public class PeriPeriSauceDecorator: ISauceDecorator
    {
        public PeriPeriSauceDecorator(IItem pizzaComponent)
        {
            pizza = pizzaComponent;
        }

        IItem pizza;
        uint cost = 30;
        string description = "Sauce = Peri Peri";

        public uint GetCost()
        {
            return cost + pizza.GetCost();
        }

        public string GetDescription()
        {
            return description;
        }
    }
}
