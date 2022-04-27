using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaternityWard.Abstract;

namespace MaternityWard.Classes.Managers
{
    public class Manager : BaseWorker
    {
        protected const double ManagerMonthlySalary = 30000;

        public Manager(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => ManagerMonthlySalary;

    }
}
