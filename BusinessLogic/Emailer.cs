﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControlProject_VS
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
        }
    }
}
