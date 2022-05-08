using HospitalMW.Interfaces;
using System;

namespace HospitalMW.Abstract
{
    public abstract class BaseWorker : IWorker
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public double HoursWorked { get; set; }

        protected BaseWorker(string id, string name, string title)
        {
            this.id = id;
            this.Name = name;
            this.Title = title;
        }

        public abstract double CalcMonthlySalary();

        public void InsertHoursWorked(DateTime clockIn, DateTime clockOut)
        {
            double minutesWorked = (clockOut - clockIn).TotalMinutes;
            HoursWorked += minutesWorked/60;
        }
        
        public void DisplayCurrentSalary()
        {
            Console.WriteLine(CalcMonthlySalary());
        }

    }
}