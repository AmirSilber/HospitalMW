using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMW.Abstract;

namespace HospitalMW.Classes.Managers
{
    public class Manager : BaseWorker
    {
        protected const double ManagerMonthlySalary = 30000;

        public Manager(string id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => ManagerMonthlySalary;

    }
}
