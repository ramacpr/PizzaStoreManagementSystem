using DecoratorPattern.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Portals
{
    public interface IPortal
    {
        void InitiateNewOrder();
        void CreateNewOrder();
        void LogOffPortal(); // user of the portal requests the portal manager to log off
        void ShowPortal();
        void ShutdownPortal();
    }
}
