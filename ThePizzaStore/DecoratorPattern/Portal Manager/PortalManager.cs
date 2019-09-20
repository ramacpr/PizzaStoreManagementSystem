using DecoratorPattern.MsgForwarding;
using DecoratorPattern.Portal_Management;
using DecoratorPattern.Portals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Portal_Manager
{
    public class PortalManager : IPortalManager, ISubscriber, IPublisher
    {
        // portal ID mapped to the portal object created.
        Dictionary<uint, IPortal> connectedPortals = new Dictionary<uint, IPortal>();

        List<ISubscriber> subscribers = new List<ISubscriber>();

        public PortalManager()
        {
        }

        #region IPortalManager methods
        public void OnConnectNewPortal()
        {
            /*
             * Future Enhancement: 
             * The type of portal can be different 
             * so bring up different portal UIs for 
             * different user selections [Factory method pattern]
             */


            uint newPortalID = (uint) connectedPortals.Count() + 1;

            IPortal newPortal = new InStorePortal(this, newPortalID);
            connectedPortals.Add(newPortalID, newPortal);

            // bring up the portal UI 
            newPortal.ShowPortal();
        }

        public void OnDisconnectPortal(uint portalID)
        {
            if (portalID <= (uint)connectedPortals.Count)
                return;

            // fetch the object from map, close the window, delete object
            IPortal portal = connectedPortals[portalID];
            if (portal is null)
                return;

            portal.ShutdownPortal(); 
        }

        public void ShowPortalManager()
        {

        }

        public void ShutdownPortalManager()
        {

        }

        #endregion

        #region ISubscriber methods
        public void OnReceivedNewUpdate(IUpdateData data)
        {
            // on receiving a new order from portal, 
            // the order details have to be forwarded to the 
            // store management (Publish to Store)

            OnNotifyNewUpdate(data); 
        }

        #endregion

        #region IPublisher methods
        public void OnNotifyNewUpdate(IUpdateData data)
        {
            foreach (ISubscriber subs in subscribers)
                subs.OnReceivedNewUpdate(data);
        }

        public void SubscribeForUpdates(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        } 
        #endregion
    }
}
