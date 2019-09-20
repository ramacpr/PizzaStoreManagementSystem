﻿using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ComponentDecorator.Toppings
{
    public class CapsicumToppingDecorator: IToppingDecorator
    {
        public CapsicumToppingDecorator(IItem pizzaComponent)
        {
            pizza = pizzaComponent;
        }

        IItem pizza;
        uint cost = 10;
        string description = "Capsicum";

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
