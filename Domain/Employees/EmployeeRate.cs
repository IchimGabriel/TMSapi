using Domain.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Employees
{
    public class EmployeeRate : AuditableEntity, IAggregateRoot
    {
        public Guid EmployeeId { get; private set; }
        public decimal Rate { get; private set; }
        public DateTime LastUpdated { get; private set; }



        public EmployeeRate(Guid employeeId, decimal rate, DateTime lastUpdated)
        {
            EmployeeId = employeeId;
            Rate = rate;
            LastUpdated = lastUpdated;  
        }

        public EmployeeRate Update(Guid? employeeId, decimal? rate, DateTime? lastUpdated)
        {
            if (employeeId.HasValue && employeeId.Value != Guid.Empty && !EmployeeId.Equals(employeeId.Value)) EmployeeId = employeeId.Value;
            if (rate.HasValue && Rate != rate) Rate = rate.Value;
            if (lastUpdated is not null && LastUpdated.Equals(lastUpdated) is true) LastUpdated = (DateTime)lastUpdated;

            return this;
        }

        public decimal GetRate(Guid? id)
        {
            if (!id.HasValue || id.Value == Guid.Empty){return 0;}
                
            return Rate;
        }
    }
}
