using MaternityWard.Abstract;

namespace MaternityWard.Classes.Ward.Nurses
{
    public class Nurse : BaseWorker
    {
        protected const double NurseHourlyRate = 60;

        public Nurse(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary(double hoursWorked) => NurseHourlyRate * hoursWorked;
        public override double CalcMonthlySalary()
        {
            throw new System.NotImplementedException("Please input hours worked");
        }
    }
}