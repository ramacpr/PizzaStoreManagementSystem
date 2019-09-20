using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ComponentDecorator.Crust
{
    public class CheeseBurstDecorator : IItem
    {
        public CheeseBurstDecorator(IItem pizzaComponent)
        {
            pizza = pizzaComponent;
        }

        IItem pizza; 
        uint cost = 50;
        string description = "Crust = Cheese Burst"; 

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
