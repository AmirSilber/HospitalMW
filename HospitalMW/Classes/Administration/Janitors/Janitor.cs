using HospitalMW.Abstract;

namespace HospitalMW.Classes
{
    public class Janitor : BaseWorker
    {
        protected const double janitorHourlyRate = 30;

        public Janitor(string id, string Name, string Title) : base(id, Name, Title) {}

        public override double CalcMonthlySalary() => janitorHourlyRate * this.HoursWorked;

    }
}