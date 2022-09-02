using SchedulingApi.Models;
using System;
using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;

namespace SchedulingApi.Repositories
{
    public class ScheduleRepository :IScheduleRepository
    {
        private CosmosClient cosmosClient;

        // The database we will create
        private Database database;

        // The container we will create.
        private Container container;

        private string databaseId = "db";
        private string containerId = "Schedules";

        public ScheduleRepository()
        {
            var AccountEndpoint = "https://localhost:8081";
            var PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

            this.cosmosClient = new CosmosClient(AccountEndpoint, PrimaryKey, new CosmosClientOptions() { ApplicationName = "ScheduleApiCosmosDB" });
        }

        public async Task SaveSchedule(Schedule schedule)
        {
            await this.CreateDatabaseAsync();
            await this.CreateContainerAsync();

            //ADD THIS PART TO YOUR CODE
            ItemResponse<Schedule> scheduleResponse = await this.container.CreateItemAsync<Schedule>(schedule, new PartitionKey(schedule.ScheduleTimeIndex));
        }

        private async Task CreateDatabaseAsync()
        {
            // Create a new database
            this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
        }

        private async Task CreateContainerAsync()
        {
            // Create a new container
            this.container = await this.database.CreateContainerIfNotExistsAsync(containerId, "Schedule", 400);
            Console.WriteLine("Created Container: {0}\n", this.container.Id);
        }

        public Schedule GetScheduleByScheduleGuid(Guid scheduleGuid)
        {
            return new Schedule();
        }
    }
}
