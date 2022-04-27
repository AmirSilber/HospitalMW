using MaternityWard.Abstract;

namespace MaternityWard.Classes.Ward.Doctors
{
    public class Doctor : BaseWorker
    {
        protected const double DoctorHourlyRate = 150;

        public Doctor(int id, string name, string title) : base(id, name, title) {}

        public override double CalcMonthlySalary() => DoctorHourlyRate * this.HoursWorked * 1.05;
    }
}