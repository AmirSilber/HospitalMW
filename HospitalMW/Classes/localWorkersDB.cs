using HospitalMW.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces;

namespace HospitalMW
{
    public class LocalWorkersDB
    {

        private Dictionary<string, BaseWorker> workers;
        public LocalWorkersDB()
        {
            this.workers = new Dictionary<string, BaseWorker>();
        }

        public void AddWorker(BaseWorker newWorker)
        {
            this.workers.Add(newWorker.id, newWorker);
        }

        public void AddListOfWorkers(List<BaseWorker> arrayOfNewWorkers)
        {
            foreach (BaseWorker newWorker in arrayOfNewWorkers)
            {
                this.workers.Add(newWorker.id, newWorker);
            }
        }

        public BaseWorker GetWorker(string workerid)
        {
            return this.workers[workerid];
        }

        //public LocalWorkersDB Execute(LocalWorkersDB tempDB) { return tempDB; }

        /*public void DisplayMonthlySalary(string workerid)
        {
            Console.WriteLine(GetWorker(workerid).CalcMonthlySalary());
        }*/
    }
}
