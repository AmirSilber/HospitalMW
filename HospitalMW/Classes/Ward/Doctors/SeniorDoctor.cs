namespace HospitalMW.Classes.Ward.Doctors
{
    public class SeniorDoctor: Doctor
    {
        public SeniorDoctor(string id, string name, string title) : base(id, name, title)
        { }

        public override double CalcMonthlySalary()
        {
            if (this.HoursWorked > 50)
                return DoctorHourlyRate * 200 * 1.05 * 1.5;
            else
                return base.CalcMonthlySalary();
        }
    }
}