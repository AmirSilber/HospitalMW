using MaternityWard.Abstract;

namespace MaternityWard.Classes
{
    class LineServer : BaseWorker
    {
        private double LineServerHourlyRate = 30;

        public LineServer(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => LineServerHourlyRate * this.HoursWorked;

    }
}