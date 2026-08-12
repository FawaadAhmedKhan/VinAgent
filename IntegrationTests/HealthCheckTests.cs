using System.Net;

namespace IntegrationTests
{
    public class HealthCheckTests
    {
        [Fact]
        public async Task Health_Check_Should_Return_OK()
        {
            var baseUrl = Environment.GetEnvironmentVariable("API_BASE_URL");

            Assert.False(string.IsNullOrWhiteSpace(baseUrl));

            using var client = new HttpClient();

            var response = await client.GetAsync($"{baseUrl}/health");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}