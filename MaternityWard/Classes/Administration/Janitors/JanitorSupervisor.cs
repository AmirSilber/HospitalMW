using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityWard.Classes.Administration.Janitors
{
    public class JanitorSupervisor : Janitor
    {
        public JanitorSupervisor(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary(double hoursWorked)
        {
            if (hoursWorked > 50)
                return janitorHourlyRate * 200 * 1.5;
            else
                return base.CalcMonthlySalary(hoursWorked);
        }
    }
}
