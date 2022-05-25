using System.Collections.Generic;
using HospitalMW.Abstract;

namespace HospitalMW.Interfaces
{
    public interface IWorkersDB
    {
        void AddWorker(BaseWorker newWorker);
        void RemoveWorker(BaseWorker oldWorker);
        void AddListOfWorkers(List<BaseWorker> arrayOfNewWorkers);
        BaseWorker GetWorker(string workerID);
    }
}