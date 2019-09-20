using DecoratorPattern.Items;
using DecoratorPattern.MsgForwarding;
using DecoratorPattern.Portal_Management;
using DecoratorPattern.Portal_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Store_Manager
{
    public class PizzaStoreManager : IStoreManager, ISubscriber 
    {
        // map of order ID and order
        Dictionary<uint, IOrder> orderQueue = new Dictionary<uint, IOrder>();

        IPortalManager portalManager = null;

        public PizzaStoreManager()
        {

        }

        #region IStoreManager methods
        public void CloseStore()
        {
            // this is the default store state
            if (portalManager != null)
                portalManager.ShutdownPortalManager();
            portalManager = null; 

            // all controls disabled
        }

        public void OpenStore()
        {
            // all controls enabled
            portalManager = new PortalManager();
            portalManager.ShowPortalManager();
        }

        public void PromoteOrderToDelivered(uint orderID)
        {
            orderQueue[orderID].PromoteOrder(OrderState.Delivered);
        }

        public void PromoteOrderToPreparing(uint orderID)
        {
            orderQueue[orderID].PromoteOrder(OrderState.Preparing);
        }

        public void PromoteOrderToReady(uint orderID)
        {
            orderQueue[orderID].PromoteOrder(OrderState.Ready);
        }

        public void CreateNewOrder(IOrder order)
        {
            uint newOrderID = (uint) orderQueue.Count + 1;
            order.PromoteOrder(OrderState.NewOrder);
            orderQueue.Add(newOrderID, order); 
        }

        public void CloseOrder(uint orderID)
        {
            orderQueue[orderID].PromoteOrder(OrderState.Closed);
        }

        public void CancelOrder(uint orderID)
        {
            OrderState theOrderStatus = orderQueue[orderID].GetOrderStatus();
            if (theOrderStatus != OrderState.NewOrder)
                // show cant cancel and return 
                return;
            orderQueue.Remove(orderID);
        }
        #endregion

        #region ISubscriber methods
        public void OnReceivedNewUpdate(IUpdateData data)
        {
            CreateNewOrder(data as IOrder);
        } 
        #endregion
    }
}
