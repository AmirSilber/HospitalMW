using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMW.Classes.Administration.Janitors
{
    public class SeniorJanitor : Janitor
    {
        public SeniorJanitor(string id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => base.CalcMonthlySalary() * 1.05;

    }
}
