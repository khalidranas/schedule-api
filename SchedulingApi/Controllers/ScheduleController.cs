using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchedulingApi.Dtos;
using SchedulingApi.Extensions;
using SchedulingApi.Models;
using SchedulingApi.Services;

namespace SchedulingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly ILogger<ScheduleController> logger;
        private readonly IScheduleService scheduleService;

        public ScheduleController(ILogger<ScheduleController> logger,
            IScheduleService scheduleService)
        {
            this.logger = logger;
            this.scheduleService = scheduleService;
        }

        [HttpGet]
        public Schedule Get(Guid scheduleId)
        {
            var schedule = this.scheduleService.GetSchedule(scheduleId);

            return schedule;
        }

        [HttpPost]
        public IActionResult Create(ScheduleDto schedule)
        {
            // Validate 
            if(schedule==null)
            {
                return new BadRequestResult();
            }

            scheduleService.CreateSchedule(schedule.ToSchedule());

            // Post data to service
            return new OkResult();
        }

        [HttpPut]
        public IActionResult Update(ScheduleDto schedule)
        {
            // Validate 

            // Post data to service
            return new OkResult();
        }

        [HttpDelete]
        public IActionResult Delete(ScheduleDto schedule)
        {
            // Validate 

            // Post data to service
            return new OkResult();
        }
    }
}