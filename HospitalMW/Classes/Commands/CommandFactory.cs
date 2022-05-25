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
        private static Dictionary<string, Type> cmdTypes = new Dictionary<string, Type>
        {
            {"ADDWORKER", typeof(AddWorker)},
            {"REMOVEWORKER", typeof(RemoveWorker)},
            {"VIEWSALARY", typeof(ViewSalary)}
        };
        
        public void AddCmdToDictionary(string cmdName, Type type)
        {
            cmdTypes.Add(cmdName.ToUpper(), type);
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
    }
}
