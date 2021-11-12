using System;

namespace Services.Services.MessageSender
{
    public interface IMessageSender
    {
        void Send(string message);
        Guid GetId();
    }
}