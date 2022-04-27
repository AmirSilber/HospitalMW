using MaternityWard.Abstract;

namespace MaternityWard.Classes.Ward.Doctors
{
    public class Doctor : BaseWorker
    {
        protected const double DoctorHourlyRate = 150;

        public Doctor(int id, string name, string title) : base(id, name, title) {}

        public override double CalcMonthlySalary(double hoursWorked) => DoctorHourlyRate * hoursWorked * 1.05;

        public override double CalcMonthlySalary()
        {
            throw new System.NotImplementedException("Please input hours worked");
        }
    }
}