namespace HospitalMW.Classes.Ward.Nurses
{
    public class ChiefNurse : Nurse
    {
        public ChiefNurse(int id, string name, string title) : base(id, name, title)
        { }

        public override double CalcMonthlySalary()
        {
            if (this.HoursWorked > 50)
                return NurseHourlyRate * 200 * 1.5 * 1.05;
            else
                return base.CalcMonthlySalary() * 1.05;
        }
    }
}