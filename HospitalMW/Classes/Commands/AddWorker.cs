using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces;
using HospitalMW.Abstract;
using HospitalMW;
using HospitalMW.Classes.Ward.Doctors;


namespace HospitalMW.Classes.Commands
{

    public class AddWorker : ICommand
    {
        string[] ADDinput;
        BaseWorker tempWorker;

        static string[] GetADDinput()
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

        public void Execute()
        {
            ADDinput = GetADDinput();
            tempWorker = new Doctor(ADDinput[0], ADDinput[1], ADDinput[2]);

        }
    }
}
