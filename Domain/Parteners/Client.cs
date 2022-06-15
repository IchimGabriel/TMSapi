using Domain.Common.Contracts;

namespace Domain.Parteners
{
    public class Client : AuditableEntity, IAggregateRoot
    {
        public string CompanyName { get; private set; } = default!;
        public string ClientName { get; private set; } = default!; 
        public string? Address { get; private set; }
        public string? PhoneNumber { get; private set; }
        public string? Details { get; private set; } 
        public DateTime AddedDate { get; private set; } 
        public virtual List<Project> Projects { get; private set; } = default!;

        public Client(string companyName, string clientName, string? address, string? phoneNumber, string? details, DateTime addedDate)
        {
            CompanyName = companyName;
            ClientName = clientName;
            Address = address;  
            PhoneNumber = phoneNumber;
            Details = details;
            AddedDate = addedDate;
        }

        public Client Update(string companyName, string clientName, string? address, string? phoneNumber, string? details)
        {
            if (companyName is not null && CompanyName?.Equals(companyName) is not true) CompanyName = companyName;
            if (clientName is not null && ClientName?.Equals(clientName) is not true) ClientName = clientName;
            if (address is not null && Address?.Equals(address) is not true) Address = address;
            if (phoneNumber is not null && PhoneNumber?.Equals(phoneNumber) is not true) PhoneNumber = phoneNumber;
            if (details is not null && Details?.Equals(details) is not true) Details = details;
            return this;
        }
    }
}
