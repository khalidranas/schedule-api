using Microsoft.Extensions.Configuration;

namespace SchedulingApi.Configurations
{
    public class AppSettings : IAppSettings
    {
        public IConfiguration _configuration;

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string SchedulerFeature
        {
            get
            {
                return _configuration.GetValue<string>("SchedulerFeature");
            }
            set
            {

            }
        }
    }
}
