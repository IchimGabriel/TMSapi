using Domain.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Parteners
{
    public class Project : AuditableEntity, IAggregateRoot
    {
        public string Name { get; private set; } = default!;
        public string? Description { get; private set; }
        public decimal ProjectValue { get; private set; }   
        public DateTime StartDate { get; private set; }
        public DateTime FinishDate { get; private set; } 
        public Guid ClientId { get; private set; }  
        public virtual Client Client { get; private set; } = default!;


        public Project(string name, string? description, decimal projectValue, DateTime startDate, DateTime finishDate, Guid clientId)
        {
            Name = name;
            Description = description;
            ProjectValue = projectValue;
            StartDate = startDate;
            FinishDate = finishDate;
            ClientId = clientId;    
        }

        public Project Update(string? name, string? description, decimal? projectValue, DateTime? startDate, DateTime? finishDate, Guid? clientId)
        {
            if (name is not null && Name?.Equals(name) is not true) Name = name;
            if (description is not null && Description?.Equals(description) is not true) Description = description;
            if (projectValue.HasValue && ProjectValue != projectValue) ProjectValue = projectValue.Value;
            if (projectValue.HasValue && ProjectValue != projectValue) ProjectValue = projectValue.Value;
            if (startDate is not null && StartDate.Equals(startDate) is true) StartDate = (DateTime)startDate;
            if (finishDate is not null && FinishDate.Equals(finishDate) is true) FinishDate = (DateTime)finishDate;
            if (clientId.HasValue && clientId.Value != Guid.Empty && !ClientId.Equals(clientId.Value)) ClientId = clientId.Value;
            return this;
        }


    }

}
