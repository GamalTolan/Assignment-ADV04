using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01

            // Employee employee = new Employee 
            // {
            //     EmployeeID = 17,
            //     BirthDate = new DateTime(1955, 7, 13),
            //     VacationStock = 5
            // };

            //employee.EmployeeLayOff += (sender, e) =>
            //{
            //    Console.WriteLine($"Employee {((Employee)sender).EmployeeID} laid off due to {e.Cause}");
            //};

            //employee.EndOfYearOperation();


            #endregion

            #region part02

            //Department department = new Department { DeptID = 15, DeptName = "HR" };

            //Employee employee = new Employee { EmployeeID = 22, BirthDate = new DateTime(2000, 1, 15), VacationStock = -1 };

            //department.AddMember(employee);

            //employee.EndOfYearOperation();


            #endregion

            #region part03

            //Club club = new Club { ClubID = 20, ClubName = "Company Club" };
            //Employee employee = new Employee { EmployeeID = 5, BirthDate = new DateTime(2005, 5 , 5), VacationStock = -1 };

            //club.AddMember(employee);
            //employee.EndOfYearOperation();


            #endregion


            #region part04

            //Club club = new Club { ClubID = 15, ClubName = "Company Club" };

            //Employee employee = new Employee{ EmployeeID = 5, BirthDate = new DateTime(2005, 5, 5), VacationStock = -1 };

            //club.AddMember(employee);

            //employee.EndOfYearOperation();

            #endregion

            #region part05

            Department department = new Department { DeptID = 101, DeptName = "Sales" };
            SalesPerson salesperson = new SalesPerson { EmployeeID = 2, BirthDate = new DateTime(1999, 9,9), AchievedTarget = 110 };
            BoardMember boardMember = new BoardMember { EmployeeID = 3, BirthDate = new DateTime(2004, 7, 13) };

            department.AddMember(salesperson);
            department.AddMember(boardMember);
            salesperson.EndOfYearOperation();
            boardMember.Resign();


            #endregion
        }
    }
}
