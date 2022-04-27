using System;
using MaternityWard.Classes;
using MaternityWard.Abstract;
using System.Collections.Generic;
using MaternityWard.Classes.Ward.Doctors;
using MaternityWard.Classes.Ward.Nurses;
using MaternityWard.Classes.Ward.Interns;
using MaternityWard.Classes.Managers;
using MaternityWard.Interfaces;

namespace MaternityWard
{
    internal static  class Program
    {

        private static void Main(string[] args)
        {

            Dictionary<int, BaseWorker> workers = new Dictionary<int, BaseWorker>();

            BaseWorker w001 = new WardManager(001, "Amir", "Chief Of Medicine");
            BaseWorker w002 = new ViceManager(002, "Yotam", "Vice Chief Of Medicine");
            BaseWorker w003 = new AdminManager(003, "Ronen", "Chief Of Administration");
            BaseWorker w004 = new ExpertDoctor(004, "Assaf", "Expert Doctor");
            BaseWorker w005 = new SeniorDoctor(005, "Alma", "Senior Doctor");
            BaseWorker w006 = new Doctor(006, "Hanan", "Junior Doctor");
            BaseWorker w007 = new BreechIntern(007, "Yogev", "Breech Intern");
            BaseWorker w008 = new Intern(008, "Kami", "Intern");
            BaseWorker w009 = new ChiefNurse(009, "Sheila", "Chief Nurse");

            List<BaseWorker> listOfEmployees = new List<BaseWorker>()
            {
                w001, w002, w003, w004, w005, w006, w007, w008, w009
            };

            LocalWorkersDB workersDB = new LocalWorkersDB();
            workersDB.AddListOfWorkers(listOfEmployees);

            Console.WriteLine(workersDB.GetWorker(001).CalcMonthlySalary());
        }
    }
}