using Newtonsoft.Json;
using System;

namespace SchedulingApi.Models
{
    public class Schedule
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        public Guid ScheduleId { get; set; }
        public string ScheduleTitle { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ScheduleDateIntex { get; set; }
        public int ScheduleTimeIndex { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
