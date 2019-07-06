using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControlProject_VS
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}
