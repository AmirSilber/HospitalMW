using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityWard.Classes.Administration.Janitors
{
    public class SeniorJanitor : Janitor
    {
        public SeniorJanitor(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary(double hoursWorked) => base.CalcMonthlySalary(hoursWorked) * 1.05;

    }
}
