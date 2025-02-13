using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV04
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Member = new List<Employee>();

        public void AddMember(Employee employee)
        {
            Member.Add(employee);
            employee.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs emp)
        {
            Employee employee = sender as Employee;
            if (employee != null && Member.Contains(employee))
            {
                Member.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from department {DeptName} due to {emp.Cause}");
            }
        }
    }
}
