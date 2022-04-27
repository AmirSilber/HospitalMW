using MaternityWard.Abstract;

namespace MaternityWard.Classes
{
    public class Janitor : BaseWorker
    {
        protected const double janitorHourlyRate = 30;

        public Janitor(int Id, string Name, string Title) : base(Id, Name, Title) {}

        public override double CalcMonthlySalary(double hoursWorked) => janitorHourlyRate * hoursWorked;

        public override double CalcMonthlySalary()
        {
            throw new System.NotImplementedException("Please input hours worked");
        }
    }
}