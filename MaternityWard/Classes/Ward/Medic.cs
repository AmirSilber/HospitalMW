﻿using MaternityWard.Abstract;

namespace MaternityWard.Classes
{
    class Medic : BaseWorker
    {
        protected const double MedicHourlyRate = 45;

        public Medic(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary(double hoursWorked) => MedicHourlyRate * hoursWorked;

        public override double CalcMonthlySalary()
        {
            throw new System.NotImplementedException("Please input hours worked");
        }

    }
}