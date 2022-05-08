namespace HospitalMW.Classes.Ward.Nurses
{
    public class BreechMidwife : Nurse
    {
        public BreechMidwife(string id, string name, string title) : base(id, name, title)
        { }

        public override double CalcMonthlySalary() => base.CalcMonthlySalary() * 1.05 *1.3;
    }
}