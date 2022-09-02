using SchedulingApi.Models;
using SchedulingApi.Repositories;
using System;
using System.Collections.Generic;

namespace SchedulingApi.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public void CreateSchedule(Schedule schedule)
        {
            _scheduleRepository.SaveSchedule(schedule);
        }

        public Schedule GetSchedule(Guid scheduleId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Schedule> GetSchedules()
        {
            throw new System.NotImplementedException();
        }
    }
}
