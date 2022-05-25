using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces; 

namespace HospitalMW.Classes.Commands
{
    public class NullCommand : ICommand
    {
        public IWorkersDB Execute(IWorkersDB tempDB)
        {
            Console.WriteLine("Invalid Command");
        }
    }
}
