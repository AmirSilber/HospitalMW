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
        public LocalWorkersDB Execute(LocalWorkersDB tempDB)
        {
            Console.WriteLine("Invalid Command");
            return null;
        }
    }
}
