using MaternityWard.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityWard
{
    public class LocalWorkersDB
    {

        private Dictionary<int, BaseWorker> workers;
        public LocalWorkersDB()
        {
            this.workers = new Dictionary<int, BaseWorker>();
        }

        public void AddWorker(BaseWorker newWorker)
        {
            this.workers.Add(newWorker.Id, newWorker);
        }

        public void AddListOfWorkers(List<BaseWorker> arrayOfNewWorkers)
        {
            foreach (BaseWorker newWorker in arrayOfNewWorkers)
            {
                this.workers.Add(newWorker.Id, newWorker);
            }
        }

        public BaseWorker GetWorker(int workerId)
        {
            return this.workers[workerId];
        }

        /*public void DisplayMonthlySalary(int workerId)
        {
            Console.WriteLine(GetWorker(workerId).CalcMonthlySalary());
        }*/
    }
}
