﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControlProject_VS
{
    public class Chore : IChore
    {
        public string ChoreName { get; set; }

        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;

            Logger log = new Logger();

            log.Log($"Performed work on { ChoreName}");

            Emailer emailer = new Emailer();

            emailer.SendMessage(Owner,$"The chore {ChoreName} is complete.");


        }

        public void CompleteWork()
        {
            IsComplete = true;

            Logger log = new Logger();

            log.Log($"Completed {ChoreName}");

            Emailer emailer = new Emailer();

            emailer.SendMessage(Owner,$"The chore {ChoreName} is complete.");
        }
    }
}
