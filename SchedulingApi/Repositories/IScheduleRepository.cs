using SchedulingApi.Models;
using System;
using System.Threading.Tasks;

namespace SchedulingApi.Repositories
{
    public interface IScheduleRepository
    {
        Task SaveSchedule(Schedule schedule);
        Schedule GetScheduleByScheduleGuid(Guid scheduleGuid);
    }
}