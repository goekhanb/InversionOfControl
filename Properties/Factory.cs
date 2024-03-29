﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControlProject_VS
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore();
        }

        public static IMessageSender CreatemessageSender()
        {
            return new Emailer();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
