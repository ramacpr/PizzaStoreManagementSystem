using DecoratorPattern.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Store_Manager
{
    public interface IStoreManager
    {
        void OpenStore();
        void CloseStore();
        void CreateNewOrder(IOrder order);
        void PromoteOrderToPreparing(uint orderID);
        void PromoteOrderToReady(uint orderID);
        void PromoteOrderToDelivered(uint orderID);
        void CloseOrder(uint orderID);
        void CancelOrder(uint orderID);
    }
}
