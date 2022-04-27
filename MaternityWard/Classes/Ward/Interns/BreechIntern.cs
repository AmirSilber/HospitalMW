namespace MaternityWard.Classes.Ward.Interns
{
    public class BreechIntern : Intern
    {
        public BreechIntern(int id, string name, string title): base(id, name, title)
        { }

        public override double CalcMonthlySalary(double hoursWorked) => base.CalcMonthlySalary(hoursWorked) * 1.3;
    }
}