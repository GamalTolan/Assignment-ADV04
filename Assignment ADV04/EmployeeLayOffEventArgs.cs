﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV04
{
    public class EmployeeLayOffEventArgs: EventArgs
    {

        public LayOffCause Cause { get; set; }

    }
}
