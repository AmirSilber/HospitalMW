using HospitalMW.Abstract;

namespace HospitalMW.Classes
{
    public class Cook : BaseWorker
    {
        protected const double cookHourlyRate = 40;

        public Cook(int id, string name, string title) : base(id, name, title) {}

        public override double CalcMonthlySalary() => cookHourlyRate * this.HoursWorked * 1.05;

    }
}