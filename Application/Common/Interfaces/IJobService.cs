using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IJobService
    {
        string Enqueue(Expression<Action> methodCall);

        string Enqueue(Expression<Func<Task>> methodCall);

        string Enqueue<T>(Expression<Action<T>> methodCall);

        string Enqueue<T>(Expression<Func<T, Task>> methodCall);

        string Schedule(Expression<Action> methodCall, TimeSpan delay);

        string Schedule(Expression<Func<Task>> methodCall, TimeSpan delay);

        string Schedule(Expression<Action> methodCall, DateTimeOffset enqueueAt);

        string Schedule(Expression<Func<Task>> methodCall, DateTimeOffset enqueueAt);

        string Schedule<T>(Expression<Action<T>> methodCall, TimeSpan delay);

        string Schedule<T>(Expression<Func<T, Task>> methodCall, TimeSpan delay);

        string Schedule<T>(Expression<Action<T>> methodCall, DateTimeOffset enqueueAt);

        string Schedule<T>(Expression<Func<T, Task>> methodCall, DateTimeOffset enqueueAt);

        bool Delete(string jobId);

        bool Delete(string jobId, string fromState);

        bool Requeue(string jobId);

        bool Requeue(string jobId, string fromState);
    }
}
