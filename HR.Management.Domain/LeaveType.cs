using HR.Management.Domain.Common;

namespace HR.Management.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }    
        public int DefaultDays { get; set; }

    }
}