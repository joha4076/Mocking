using System;

namespace Mocking
{
    public class Employee
    {
        public Employee()
        {

        }
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Wage { get; set; }
        public int hours { get; set; }
        public MailBox MailBox { get; set; }

        public double CalculateWeeklySalary(int Hours, int wage)
        {
            hours = Hours;
            wage = Wage;

            return hours * wage;
        }
    }
}