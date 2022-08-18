﻿using HR.Management.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Management.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
         public int NumberOfDays { get; set; }   
        public LeaveType LeaveType { get; set; }    
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }

    }
}
