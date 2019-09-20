using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Items;
using DecoratorPattern.MsgForwarding;
using DecoratorPattern.Portal_Management;

namespace DecoratorPattern.Portals
{
    public class InStorePortal : IPortal, IPublisher
    {
        List<ISubscriber> orderUpdateSubscribers = new List<ISubscriber>();
        IPortalManager portalManager = null;
        uint myPortalID = 0; 

        // takes reference of the portal manager to be able to 
        // send back order notification
        public InStorePortal(IPortalManager portalMgmt, uint portalID)
        {
            portalManager = portalMgmt;
            myPortalID = portalID;

            // portal manager waits for new order updates from portals. 
            SubscribeForUpdates(portalMgmt as ISubscriber);
        }

        public void ShowPortal()
        {
            // display modeless portal window
        }

        public void ShutdownPortal()
        {
            // close the window
        }

        public void CreateNewOrder()
        {
            // create the IOrder object here for the new order 
            IOrder orderItems = null;

            /*
             * 
             */


            // notify the subscribers
            OnNotifyNewUpdate(orderItems as IUpdateData);
        }

        public void InitiateNewOrder()
        {
            throw new NotImplementedException();
        }

        public void LogOffPortal()
        {
            /*
             * change this to command instead!
             */
            portalManager.OnDisconnectPortal(myPortalID);
        }

        #region IPublisher methods
        public void OnNotifyNewUpdate(IUpdateData data)
        {
            foreach (ISubscriber subs in orderUpdateSubscribers)
                subs.OnReceivedNewUpdate(data);
        }

        public void SubscribeForUpdates(ISubscriber subscriber)
        {
            orderUpdateSubscribers.Add(subscriber);
        } 
        #endregion
    }
}
