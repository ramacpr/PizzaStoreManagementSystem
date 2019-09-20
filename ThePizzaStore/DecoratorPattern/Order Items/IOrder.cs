using DecoratorPattern.Component;
using DecoratorPattern.MsgForwarding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Items
{
    public enum OrderState
    {
        NewOrder = 1,
        Preparing,
        Ready,
        Delivered,
        Closed,
        Cancelled
    }

    public interface IOrder: IUpdateData 
    {
        void AddItem(IItem item);

        void RemoveItem(IItem item);

        void RemoveAllItems();

        void PromoteOrder(OrderState newState);

        OrderState GetOrderStatus();
    }
}
