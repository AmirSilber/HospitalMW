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
        public LocalWorkersDB Execute(LocalWorkersDB tempDB)
        {
            return tempDB;
        }
    }
}
