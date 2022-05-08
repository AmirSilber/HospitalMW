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
    internal static  class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the client, use the following commands: \n" +
                "ADDWORKER - Add a worker to the DB \n" +
                "REMOVEWORKER - Remove a worker from the DB \n" +
                "CLOCKIN *id* - Clock in a worker by id \n" +
                "CLOCKOUT *id* - Clock out a worker by id\n" +
                "VIEWSALARY - View a worker's current salary \n" +
                "TERMINATE - Terminate the program \n");

            string adminInput = Console.ReadLine();

            while (adminInput != "TERMINATE")
            {
                switch (adminInput.ToUpper())
                {
                    case "ADDWORKER":
                        CommandFactory.GetCommand<AddWorker>().Execute();
                        break;
                    case "REMOVEWORKER":
                        CommandFactory.GetCommand<RemoveWorker>().Execute();
                        break;
                    case "VIEWSALARY":
                        CommandFactory.GetCommand<ViewSalary>().Execute();
                        break;
                        
                    default:
                        CommandFactory.GetCommand<NullCommand>().Execute();
                        break;
                }
                adminInput = Console.ReadLine();
            }
        }
    }
}