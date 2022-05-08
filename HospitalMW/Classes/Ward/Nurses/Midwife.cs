﻿namespace HospitalMW.Classes.Ward.Nurses
{
    public class Midwife : Nurse
    {
        public Midwife(string id, string name, string title) : base(id, name, title)
        { }

        public override double CalcMonthlySalary() => base.CalcMonthlySalary() * 1.05;
    }
}