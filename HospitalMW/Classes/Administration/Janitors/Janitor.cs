using HospitalMW.Abstract;

namespace HospitalMW.Classes
{
    public class Janitor : BaseWorker
    {
        protected const double janitorHourlyRate = 30;

        public Janitor(int Id, string Name, string Title) : base(Id, Name, Title) {}

        public override double CalcMonthlySalary() => janitorHourlyRate * this.HoursWorked;

    }
}