using HospitalMW.Abstract;

namespace HospitalMW.Classes
{
    class Medic : BaseWorker
    {
        protected const double MedicHourlyRate = 45;

        public Medic(string id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => MedicHourlyRate * this.HoursWorked;

    }
}