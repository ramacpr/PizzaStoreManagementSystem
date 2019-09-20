﻿using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ComponentDecorator.Crust
{
    public class HandTossedDecorator : ICrustDecorator
    {
        public HandTossedDecorator(IItem pizzaComponent)
        {
            pizza = pizzaComponent;
        }

        IItem pizza;
        uint cost = 30;
        string description = "Crust = Hand Tossed";

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
