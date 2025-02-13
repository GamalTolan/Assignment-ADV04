using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV04
{

    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;


        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs emp)
        {
            EmployeeLayOff?.Invoke(this, emp);
        }

        public int EmployeeID { get; set; }
        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        private int vacationStock;
        public int VacationStock
        {
            get { return vacationStock; }
            set { vacationStock = value; }
        }

        public bool RequestVacation(DateTime from, DateTime to)
        {

            int vacationDays = (to - from).Days;

            if (vacationDays <= VacationStock)
            {
                VacationStock -= vacationDays;
                return true;
            }

            else
            {
                return false;
            }
        }
        public virtual void EndOfYearOperation()
        {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
            }
            else if (DateTime.Now.Year - BirthDate.Year > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeOver60 });
            }
        }

    }
}   
