using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMW.Classes.Administration.Cooks
{
    public class SousChef : Cook
    {
        public SousChef(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => base.CalcMonthlySalary() * 1.05 * 1.3;
    }
}
