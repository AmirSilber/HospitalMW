using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces;

namespace HospitalMW.Classes.Commands
{
    public class ViewSalary : ICommand
    {
        private static string GetVIEWSALARYinput()
        {
            Console.WriteLine("ID?");
            return Console.ReadLine();
        }

        public IWorkersDB Execute(IWorkersDB tempDB)
        {
            string tempID = GetVIEWSALARYinput();
            tempDB.GetWorker(tempID).DisplayCurrentSalary();
            return tempDB;
        }
    }
}
