namespace HospitalMW.Classes.Ward.Doctors
{
    public class ExpertDoctor : Doctor
    {
        public ExpertDoctor (string id, string name, string title) : base(id, name, title)
        { }

        public override double CalcMonthlySalary() => base.CalcMonthlySalary() * 1.3 * 1.5;
    }
}