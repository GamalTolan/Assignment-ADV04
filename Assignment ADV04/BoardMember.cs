﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV04
{
    internal class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
        }
    }
    
}
