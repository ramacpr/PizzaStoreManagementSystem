using DecoratorPattern.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Portal_Management
{
    public interface IPortalManager
    {
        void OnConnectNewPortal();
        void OnDisconnectPortal(uint portalID);

        void ShowPortalManager();
        void ShutdownPortalManager();
    }
}
