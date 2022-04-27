using MaternityWard.Abstract;

namespace MaternityWard.Classes.Ward.Nurses
{
    public class Nurse : BaseWorker
    {
        protected const double NurseHourlyRate = 60;

        public Nurse(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => NurseHourlyRate * this.HoursWorked;
    }
}