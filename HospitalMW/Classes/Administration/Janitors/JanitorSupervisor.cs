﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMW.Classes.Administration.Janitors
{
    public class JanitorSupervisor : Janitor
    {
        public JanitorSupervisor(string id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary()
        {
            if (this.HoursWorked > 50)
                return janitorHourlyRate * 200 * 1.5;
            else
                return base.CalcMonthlySalary();
        }
    }
}
