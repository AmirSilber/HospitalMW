namespace HospitalMW.Classes.Ward.Interns
{
    public class BreechIntern : Intern
    {
        public BreechIntern(string id, string name, string title): base(id, name, title)
        { }

        public override double CalcMonthlySalary() => base.CalcMonthlySalary() * 1.3;
    }
}