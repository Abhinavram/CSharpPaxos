﻿using CSharpPaxosRuntime.Messaging.Bus;

namespace CSharpPaxosRuntime.Messaging.Properties
{
    public interface IMessageSenderProperty
    {
        MessageSender MessageSender { get; set; }
    }
}