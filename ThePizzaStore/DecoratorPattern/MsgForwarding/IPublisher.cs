using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.MsgForwarding
{
    public interface IPublisher
    {
        void SubscribeForUpdates(ISubscriber subscriber);

        void OnNotifyNewUpdate(IUpdateData data);
    }
}
