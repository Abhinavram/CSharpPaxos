﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPaxosRuntime.Messaging.PaxosSpecificMessageTypes
{
    public class SolicitateBallotRequest : IMessage
    {
        IMessageSender IMessage.Sender
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}