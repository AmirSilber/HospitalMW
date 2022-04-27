namespace MaternityWard.Classes.Ward.Doctors
{
    public class ExpertDoctor : Doctor
    {
        public ExpertDoctor (int id, string name, string title) : base(id, name, title)
        { }

        public override double CalcMonthlySalary(double hoursWorked) => base.CalcMonthlySalary(hoursWorked) * 1.3 * 1.5;
    }
}