using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces;

namespace HospitalMW.Classes.Commands
{
    public class RemoveWorker : ICommand
    {
        private static string GetREMOVEinput()
        {
            Console.WriteLine("ID?");
            return Console.ReadLine();
        }

        public IWorkersDB Execute(IWorkersDB tempDB)
        {
            string tempID = GetREMOVEinput();
            tempDB.RemoveWorker(tempDB.GetWorker(tempID));
            return tempDB;
        }
    }
}
