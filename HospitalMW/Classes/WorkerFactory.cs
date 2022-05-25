using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Interfaces;
using HospitalMW.Abstract;
using HospitalMW.Classes.Managers;
using HospitalMW.Classes.Ward.Doctors;

namespace HospitalMW
{
    public class WorkerFactory
    {
        //need to manually complete dictionary
        private static Dictionary<string, Type> workerTypes = new Dictionary<string, Type>
        {
            {"ward manager", typeof(WardManager)},
            {"admin manager", typeof(AdminManager)},
            {"vice manager", typeof(ViceManager)},
            {"doctor", typeof(Doctor)}
        };

        public void AddTitleToDictionary(string title, Type type)
        {
            workerTypes.Add(title, type);
        }

        public static BaseWorker CreateWorker(string id, string name, string title)
        {
            Type workerType = workerTypes[title.ToLower()];
            BaseWorker tempWorker = (BaseWorker)Activator.CreateInstance(workerType, id, name, title);
            return tempWorker;
        }

        public static BaseWorker CreateWorkerByParamArr(string[] paramArr)
        {
            Type workerType = workerTypes[paramArr[2]];
            BaseWorker tempWorker = (BaseWorker)Activator.CreateInstance(workerType, paramArr[0], paramArr[1], paramArr[2]);
            return tempWorker;
        }


       public IWorker CreateWorker<T>(Type workerType, string id, string name, string title) where T : IWorker
       {
           var a = new workerType(id, name, title);
            Type type = typeof(T);
            Object obj = Activator.CreateInstance(type);
            return (T)obj;
        }
        
        
        
    }
}
