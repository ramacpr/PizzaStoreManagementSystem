using DecoratorPattern.Component;
using DecoratorPattern.Items;
using DecoratorPattern.Portal_Management;
using DecoratorPattern.Portal_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Order_Items
{
    public class PizzaStoreOrder : IOrder
    {
        List<IItem> orderItems = new List<IItem>();
        OrderState state; 

        public PizzaStoreOrder()
        {

        }

        public void AddItem(IItem item)
        {
            orderItems.Add(item); 
        }

        public void RemoveAllItems()
        {
            orderItems.Clear();
        }

        public void RemoveItem(IItem item)
        {
            orderItems.Remove(item);
        }

        public void PromoteOrder(OrderState newState)
        {
            state = newState;
        }

        public OrderState GetOrderStatus()
        {
            return state;
        }
    }
}
