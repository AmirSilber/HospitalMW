using HospitalMW.Abstract;

namespace HospitalMW.Classes
{
    class LineServer : BaseWorker
    {
        private double LineServerHourlyRate = 30;

        public LineServer(string id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => LineServerHourlyRate * this.HoursWorked;

    }
}