using HospitalMW.Abstract;

namespace HospitalMW.Classes.Ward.Interns
{
    public class Intern : BaseWorker
    {
        protected const double internHourlyRate = 50;

        public Intern(int id, string name, string title) : base(id, name, title) {}

        public override double CalcMonthlySalary() => internHourlyRate * this.HoursWorked;

    }
}