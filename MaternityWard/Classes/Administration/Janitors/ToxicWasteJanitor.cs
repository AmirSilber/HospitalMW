using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityWard.Classes.Administration.Janitors
{
    public class ToxicWasteJanitor : Janitor
    {
        public ToxicWasteJanitor(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary(double hoursWorked)
        {
            if (hoursWorked > 50)
            {
                return base.CalcMonthlySalary(hoursWorked) * 200 * 1.5 * 1.3 * 1.2;
            }
            return base.CalcMonthlySalary(hoursWorked) * 1.3 * 1.2;
        }
    }
}
