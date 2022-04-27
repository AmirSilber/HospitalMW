using MaternityWard.Abstract;

namespace MaternityWard.Classes
{
    public class Cook : BaseWorker
    {
        protected const double cookHourlyRate = 40;

        public Cook(int id, string name, string title) : base(id, name, title) {}

        public override double CalcMonthlySalary(double hoursWorked) => cookHourlyRate * 1.05;

        public override double CalcMonthlySalary()
        {
            throw new System.NotImplementedException("Please input hours worked");
        }

    }
}