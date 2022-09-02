using SchedulingApi.Models;
using System;
using System.Collections.Generic;

namespace SchedulingApi.Services
{
    public interface IScheduleService
    {
        void CreateSchedule(Schedule schedule);
        IEnumerable<Schedule> GetSchedules();
        Schedule GetSchedule(Guid scheduleId);
    }
}