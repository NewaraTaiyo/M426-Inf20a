using System;
using Payroll.ThirdParty;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee johnDoe = new Employee("John", "Doe", 120000);
            Employee jayneDone = new Employee("Jane", "Done", 125000);
            Console.WriteLine(johnDoe.GetFullName());
            Console.WriteLine(jayneDone.GetFullName());

            johnDoe.AddNote("AccountDetails", "ABC-123");
            johnDoe.AddNote("Position", "Lead Engineer");
            jayneDone.AddNote("AccountDetails", "XYZ-789");
            johnDoe.AddNote("Position", "Head of HR");


            Banking.PayOut(johnDoe, johnDoe.GetSalary() / 12);
            Banking.PayOut(jayneDone, jayneDone.GetSalary() / 12);
        }
    }
}
