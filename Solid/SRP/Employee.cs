using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public decimal CalculateYearlySalary()
        {
            return Salary * 12;
        }
        public void GenerateReport(string reportType)
        {
            //Code to generate report based on reportType
        }
        public void SendNotification(string recipient, string message)
        {
            //Code to send email notification
        }
    }

    public class SREmployee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        // related to the employee's data, it doesn't violate the SRP.
        public decimal CalculateYearlySalary()
        {
            return Salary * 12;
        }
    }

    public class ReportGenerator
    {
        public void GenerateReport(SREmployee employee, string reportType)
        {
            //Code to generate report based on reportType
        }
    }

    public class Notification
    {
        public void SendNotification(SREmployee employee, string recipient, string message)
        {
            // Code to send email notification
        }
    }
}
