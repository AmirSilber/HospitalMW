using HospitalMW.Abstract;

namespace HospitalMW.Classes.Ward.Nurses
{
    public class Nurse : BaseWorker
    {
        protected const double NurseHourlyRate = 60;

        public Nurse(string id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => NurseHourlyRate * this.HoursWorked;
    }
}