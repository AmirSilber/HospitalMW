using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces;

namespace HospitalMW.Classes.Commands
{
    public class CommandFactory
    {
        public static T GetCommand<T>() where T : ICommand
        {
            Type type = typeof(T);
            Object obj = Activator.CreateInstance(type);
            return (T)obj;
        }
    }
}
