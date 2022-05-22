using System;
using HospitalMW.Classes;
using HospitalMW.Abstract;
using System.Collections.Generic;
using HospitalMW.Classes.Ward.Doctors;
using HospitalMW.Classes.Ward.Nurses;
using HospitalMW.Classes.Ward.Interns;
using HospitalMW.Classes.Managers;
using HospitalMW.Interfaces;
using HospitalMW.Classes.Commands;

namespace HospitalMW
{
    internal static class Program
    {
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

        private static void Main(string[] args)
        {
            LocalWorkersDB workersDB = new LocalWorkersDB();

            Console.WriteLine("Welcome to the client, use the following commands: \n" +
                "ADDWORKER - Add a worker to the DB \n" +
                "REMOVEWORKER - Remove a worker from the DB \n" +
                "CLOCKIN *id* - Clock in a worker by id \n" +
                "CLOCKOUT *id* - Clock out a worker by id\n" +
                "VIEWSALARY - View a worker's current salary \n" +
                "TERMINATE - Terminate the program \n");

            string adminInput = Console.ReadLine();

            while (adminInput.ToUpper() != "TERMINATE")
            {
                workersDB = CommandFactory.GetCommand(adminInput.ToUpper()).Execute(workersDB);
                adminInput = Console.ReadLine();
            }

            //test
            Console.WriteLine(workersDB.GetWorker("33").CalcMonthlySalary());

        }
    }
}