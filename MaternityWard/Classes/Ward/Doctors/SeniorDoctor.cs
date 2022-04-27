namespace MaternityWard.Classes.Ward.Doctors
{
    public class SeniorDoctor: Doctor
    {
        public SeniorDoctor(int id, string name, string title) : base(id, name, title)
        { }

        public override double CalcMonthlySalary(double hoursWorked)
        {
            var salary = base.CalcMonthlySalary(hoursWorked);
            if (hoursWorked > 50)
            {
                return salary * 1.5;
            }
            
            return salary;
        }
    }
}