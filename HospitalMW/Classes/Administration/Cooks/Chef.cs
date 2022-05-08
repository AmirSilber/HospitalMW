using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMW.Classes.Administration.Cooks
{
    public class Chef : Cook
    {
        public Chef(string id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary()
        {
            if (this.HoursWorked > 50)
                return cookHourlyRate * 200 * 1.5 * 1.3 * 1.05;
            else
                return base.CalcMonthlySalary() * 1.3;
        }
    }
}
