using Domain.Common.Contracts;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public decimal CurrentDayRate { get; private set; }
        public string? Notes { get; private set; } = default!;
        public virtual EmployeeRate Rate { get; private set; } = default!;


        public TimeRecord(DateOnly recordDate, Guid employeeId, 
            DateTime startTime, DateTime finishTime, LunchBreak lunchBreak, decimal currentDayRate,
            string? notes)
        {
            var employeeRate = Rate.GetRate(employeeId);
            currentDayRate = TotalHours(startTime, finishTime, lunchBreak) * (employeeRate / 60);

            RecordDate = recordDate;
            EmpoyeeId = employeeId;
            StartTime = startTime;
            FinishTime = finishTime;
            Break = lunchBreak;
            CurrentDayRate = currentDayRate;
            Notes = notes;
        }

        public TimeRecord Update(DateOnly? recordDate, Guid? employeeId,
            DateTime? startTime, DateTime? finishTime, LunchBreak? lunchBreak, decimal? currentDayRate,
            string? notes)
        {
            var employeeRate = Rate.GetRate(employeeId);
            var dayRate = TotalHours(startTime, finishTime, lunchBreak) * (employeeRate / 60);
            

            if (recordDate is not null && RecordDate.Equals(recordDate) is not true) RecordDate = (DateOnly)recordDate;
            if (employeeId.HasValue && employeeId.Value != Guid.Empty && !EmpoyeeId.Equals(employeeId.Value)) EmpoyeeId = employeeId.Value;
            if (startTime is not null && StartTime.Equals(startTime) is true) StartTime = (DateTime)startTime;
            if (finishTime is not null && FinishTime.Equals(finishTime) is true) FinishTime = (DateTime)finishTime;
            if (lunchBreak is not null && Break.Equals(lunchBreak) is not true) Break = (LunchBreak)lunchBreak;
            if (currentDayRate.HasValue && CurrentDayRate != currentDayRate) CurrentDayRate = dayRate;
            if (notes is not null && Notes?.Equals(notes) is not true) Notes = notes;

            return this;
        }

        static decimal TotalHours(DateTime? startTime, DateTime? finishTime, LunchBreak? lunchBreak)
        {
            double totalHoursWorked = 0;
            if (startTime is not null && startTime < finishTime)
            {
                if (lunchBreak == LunchBreak.HalfHour)
                {
                    totalHoursWorked = (double)(finishTime - startTime).Value.TotalMinutes - 30;
                }
                else
                {
                    totalHoursWorked = (double)(finishTime - startTime).Value.TotalMinutes - 60;
                }
            }

            return (decimal)totalHoursWorked;
        }
    }
}
