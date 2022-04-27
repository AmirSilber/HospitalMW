namespace MaternityWard.Classes.Ward.Nurses
{
    public class Midwife : Nurse
    {
        public Midwife(int id, string name, string title) : base(id, name, title)
        { }

        public override double CalcMonthlySalary(double hoursWorked) => base.CalcMonthlySalary(hoursWorked) * 1.05;
    }
}