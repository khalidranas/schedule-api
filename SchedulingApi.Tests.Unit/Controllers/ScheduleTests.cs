using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;
using SchedulingApi.Controllers;
using SchedulingApi.Services;
using Xunit;

namespace SchedulingApi.Tests.Unit.Controllers
{
    public class ScheduleTests
    {
        private readonly ILogger<ScheduleController> _logger;
        private readonly IScheduleService _scheduleService;
        private readonly ScheduleController _sut;

        public ScheduleTests()
        {
            _logger = Substitute.For<ILogger<ScheduleController>>();
            _scheduleService = Substitute.For<IScheduleService>();

            _sut = new ScheduleController(_logger, _scheduleService);
        }

        [Fact]
        public void GivenScheduleInputData_WhenCalledCreate_ThenReturnsOKResponse()
        {
            var result = _sut.Create(null);
            Assert.IsType<BadRequestResult>(result);
        }
    }
}