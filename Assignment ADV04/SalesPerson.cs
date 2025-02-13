using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV04
{
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int Quota)
        {
            return AchievedTarget >= Quota;
        }

        public override void EndOfYearOperation()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (age > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeOver60 });
            }
        }

    }
}
