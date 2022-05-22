using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces;
using HospitalMW.Abstract;
using HospitalMW;
using HospitalMW.Classes.Ward.Doctors;
using HospitalMW.Classes;


namespace HospitalMW.Classes.Commands
{

    public class AddWorker : ICommand
    {
        private string[] ADDinput;

        private string[] GetADDinput()
        {
            string[] ADDarr = new string[3];
            Console.WriteLine("ID?");
            ADDarr[0] = Console.ReadLine();
            Console.WriteLine("Full Name?");
            ADDarr[1] = Console.ReadLine();
            Console.WriteLine("Title?");
            ADDarr[2] = Console.ReadLine();
            return ADDarr;
        }

        public LocalWorkersDB Execute(LocalWorkersDB tempDB)
        {
            ADDinput = GetADDinput();
            BaseWorker tempWorker = WorkerFactory.CreateWorkerByParamArr(ADDinput);
            tempDB.AddWorker(tempWorker);
            return tempDB;
        }
    }
}
