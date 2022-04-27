using MaternityWard.Abstract;

namespace MaternityWard.Classes.Ward.Interns
{
    public class Intern : BaseWorker
    {
        protected const double internHourlyRate = 50;

        public Intern(int id, string name, string title) : base(id, name, title) {}

        public override double CalcMonthlySalary() => internHourlyRate * this.HoursWorked;

    }
}