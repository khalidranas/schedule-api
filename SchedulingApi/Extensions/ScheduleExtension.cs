using SchedulingApi.Dtos;
using SchedulingApi.Models;

namespace SchedulingApi.Extensions
{
    public static class ScheduleExtension
    {
        public static Schedule ToSchedule(this ScheduleDto schedule)
        {
            return new Schedule
            {
                CreatedBy = schedule.CreatedBy,
                CreatedDate = schedule.CreatedDate,
                ScheduleDateIntex = schedule.ScheduleDate.ToDateIndex(),
                ScheduleId = schedule.ScheduleId,
                ScheduleTimeIndex = schedule.ScheduleTime.ToTimeIndex(),
                ScheduleTitle = schedule.ScheduleTitle,
                UpdatedBy = schedule.UpdatedBy,
                UpdatedDate = schedule.UpdatedDate,
            };
        }

        public static ScheduleDto ToScheduleDto(this Schedule schedule)
        {
            return new ScheduleDto
            {
                CreatedBy = schedule.CreatedBy,
                CreatedDate = schedule.CreatedDate,
                ScheduleDate = schedule.ScheduleDateIntex.ToDate().ToString("d"),
                ScheduleId = schedule.ScheduleId,
                ScheduleTime = schedule.ScheduleTimeIndex.ToTime(),
                ScheduleTitle = schedule.ScheduleTitle,
                UpdatedBy = schedule.UpdatedBy,
                UpdatedDate = schedule.UpdatedDate,
            };
        }

    }
}
