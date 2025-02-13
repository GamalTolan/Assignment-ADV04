using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV04
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }

        List<Employee> Members = new List<Employee>();

        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs emp)
        {
            Employee employee = sender as Employee;
            if (employee != null && Members.Contains(employee) && emp.Cause == LayOffCause.VacationStockNegative)
            {
                Members.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from {ClubName} due to {emp.Cause}");
            }
        }
    }
}
