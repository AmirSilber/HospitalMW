using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces; 

namespace HospitalMW.Classes.Commands
{
    internal class NullCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Invalid Command");
        }
    }
}
