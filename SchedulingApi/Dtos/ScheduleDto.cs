using System;

namespace SchedulingApi.Dtos
{
    public class ScheduleDto
    {
        public Guid ScheduleId { get; set; }
        public string ScheduleTitle { get; set; }
        public string ScheduleDate { get; set; }
        public string ScheduleTime { get; set; }
        public int ScheduleUserId { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public Guid Organisationid { get; set; }
    }
}
