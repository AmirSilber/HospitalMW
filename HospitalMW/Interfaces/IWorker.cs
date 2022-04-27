using System;

namespace HospitalMW.Interfaces
{
    public interface IWorker
    {
        int Id { get; set; }
        string Name { get; set; }
        string Title { get; set; }

        double HoursWorked { get; set; }

        double CalcMonthlySalary();

        void InsertHoursWorked(DateTime clockIn, DateTime clockOut);

    }
}