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
        private Dictionary<string, ICommand> cmdTypes = new Dictionary<string, ICommand> { };
        
        public void AddCommand(string cmdName, ICommand command)
        {
            cmdTypes.Add(cmdName.ToUpper(), command);
        }

        public static ICommand GetCommand(string cmd)
        {
            if (!cmdTypes.ContainsKey(cmd.ToUpper()))
                return new NullCommand();
            Type cmdType = cmdTypes[cmd];
            ICommand tempCmd = (ICommand)Activator.CreateInstance(cmdType);
            return tempCmd;
        }

        /*public static T GetCommand<T>() where T : ICommand
        {
            Type type = typeof(T);
            Object obj = Activator.CreateInstance(type);
            return (T)obj;
        }*/

        private void RunCommand(string command)
        {
            this.cmdTypes[command].Execute();
        }
    }
}
