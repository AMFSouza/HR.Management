using HR.Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Management.Application.DTOs
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }

    }
}
