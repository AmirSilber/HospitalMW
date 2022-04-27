using MaternityWard.Abstract;
using MaternityWard.Interfaces;

namespace MaternityWard.Classes
{
    class Paramedic : BaseWorker, IWorker
    {
        protected const double paramedicHourlyRate = 50;

        public Paramedic(int id, string name, string title) : base(id, name, title) { }

        public override double CalcMonthlySalary() => paramedicHourlyRate * this.HoursWorked;

    }
}