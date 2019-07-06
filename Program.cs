using InversionOfControlProject_VS;
using System;

namespace InversionOfControl
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@hotmail.de";
            owner.PhoneNumber = "012346678999";


            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;            
            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteWork();

            Console.ReadLine();

        }
    }
}