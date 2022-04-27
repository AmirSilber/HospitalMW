using MaternityWard.Interfaces;
using System;

namespace MaternityWard.Abstract
{
    public abstract class BaseWorker : IWorker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public double HoursWorked { get; set; }

        protected BaseWorker(int id, string name, string title)
        {
            this.Id = id;
            this.Name = name;
            this.Title = title;
        }

        public abstract double CalcMonthlySalary(double hoursWorked);

        public abstract double CalcMonthlySalary();

        public void InsertHoursWorked(DateTime clockIn, DateTime clockOut)
        {
            double minutesWorked = (clockOut - clockIn).TotalMinutes;
            HoursWorked += minutesWorked/60;
        }
        
        public void DisplayCurrentSalary()
        {
            Console.WriteLine(CalcMonthlySalary(HoursWorked));
        }

    }
}