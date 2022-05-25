using System;
using System.Threading;
using HospitalMW.Classes.Commands;
using HospitalMW.Interfaces;

namespace HospitalMW.Classes
{
    public class HospitalMW
    {

        private IWorkersDB WorkersDB; 
        public HospitalMW(IWorkersDB workersDB)
        {
            this.WorkersDB = workersDB;
            
            CommandFactory commandFactory = new CommandFactory();
            commandFactory.AddCommand("ADDWORKER", new AddWorker());
            commandFactory.AddCommand("REMOVEWORKER", new RemoveWorker());
            commandFactory.AddCommand("VIEWSALARY", new ViewSalary());
            
            Console.WriteLine("Welcome to the client, use the following commands: \n" +
                              "ADDWORKER - Add a worker to the DB \n" +
                              "REMOVEWORKER - Remove a worker from the DB \n" +
                              "CLOCKIN *id* - Clock in a worker by id \n" +
                              "CLOCKOUT *id* - Clock out a worker by id\n" +
                              "VIEWSALARY - View a worker's current salary \n" +
                              "TERMINATE - Terminate the program \n");

        }


        private void listenForInput()
        {
            string adminInput = null;
            while (adminInput.ToUpper() != "TERMINATE")
            {
                adminInput = Console.ReadLine();
                CommandFactory.GetCommand(adminInput.ToUpper()).Execute(workersDB);
            }
        }

        public void init()
        {
                
        }
    }
}