using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityWard.Classes.Administration.Cooks
{
    public class Chef : Cook
    {
        public Chef(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary(double hoursWorked)
        {
            if (hoursWorked > 50)
                return cookHourlyRate * 200 * 1.5 * 1.3 * 1.05;
            else
                return cookHourlyRate * 1.05 * 1.3;
        }
    }
}
