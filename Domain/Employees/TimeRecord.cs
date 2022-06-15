using Domain.Common.Contracts;

namespace Domain.Employees
{
    public enum LunchBreak
    {
        OneHour,
        HalfHour
    }
    public class TimeRecord : AuditableEntity, IAggregateRoot
    {
        public DateOnly RecordDate { get; private set; } 
        public Guid EmpoyeeId { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime FinishTime { get; private set; }
        public LunchBreak Break { get; private set; }
        public string? Notes { get; private set; } = default!;
        public virtual EmployeeRate Rate { get; private set; } = default!;


        public TimeRecord(DateOnly recordDate, Guid employeeId, 
            DateTime startTime, DateTime finishTime, LunchBreak lunchBreak, 
            string? notes)
        {
            RecordDate = recordDate;
            EmpoyeeId = employeeId;
            StartTime = startTime;
            FinishTime = finishTime;
            Break = lunchBreak;
            Notes = notes;
        }

        public TimeRecord Update(DateOnly? recordDate, Guid? employeeId,
            DateTime? startTime, DateTime? finishTime, LunchBreak? lunchBreak,
            string? notes)
        {
            if (recordDate is not null && RecordDate.Equals(recordDate) is not true) RecordDate = (DateOnly)recordDate;
            if (employeeId.HasValue && employeeId.Value != Guid.Empty && !EmpoyeeId.Equals(employeeId.Value)) EmpoyeeId = employeeId.Value;
            if (startTime is not null && StartTime.Equals(startTime) is true) StartTime = (DateTime)startTime;
            if (finishTime is not null && FinishTime.Equals(finishTime) is true) FinishTime = (DateTime)finishTime;
            if (lunchBreak is not null && Break.Equals(lunchBreak) is not true) Break = (LunchBreak)lunchBreak;
            if (notes is not null && Notes?.Equals(notes) is not true) Notes = notes;

            return this;
        }

        //static decimal TotalHours(DateTime? startTime, DateTime? finishTime, LunchBreak? lunchBreak)
        //{
        //    double totalHoursWorked = 0;
        //    if (startTime is not null && startTime < finishTime)
        //    {
        //        if (lunchBreak == LunchBreak.HalfHour)
        //        {
        //            totalHoursWorked = (double)(finishTime - startTime).Value.TotalMinutes - 30;
        //        }
        //        else
        //        {
        //            totalHoursWorked = (double)(finishTime - startTime).Value.TotalMinutes - 60;
        //        }
        //    }

        //    return (decimal)totalHoursWorked;
        //}
    }
}
