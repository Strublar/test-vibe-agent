using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace test_vibe_agent.Tests
{
    /// <summary>
    /// Tests unitaires pour le PingController
    /// Vérifie le bon fonctionnement de l'endpoint ping
    /// </summary>
    public class PingControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient _client;

        public PingControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact]
        public async Task Get_Ping_Returns_Pong()
        {
            // Arrange
            const string endpoint = "/ping";

            // Act
            var response = await _client.GetAsync(endpoint);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            
            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("pong", content);
        }

        [Fact]
        public async Task Get_Ping_Returns_Correct_ContentType()
        {
            // Arrange
            const string endpoint = "/ping";

            // Act
            var response = await _client.GetAsync(endpoint);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("text/plain; charset=utf-8", response.Content.Headers.ContentType?.ToString());
        }

        [Fact]
        public async Task Get_Ping_Is_Case_Insensitive()
        {
            // Arrange
            var endpoints = new[] { "/ping", "/Ping", "/PING", "/PiNg" };

            // Act & Assert
            foreach (var endpoint in endpoints)
            {
                var response = await _client.GetAsync(endpoint);
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                
                var content = await response.Content.ReadAsStringAsync();
                Assert.Equal("pong", content);
            }
        }

        [Fact]
        public async Task Get_Ping_Performance_Test()
        {
            // Arrange
            const string endpoint = "/ping";
            const int numberOfRequests = 100;
            var tasks = new Task[numberOfRequests];

            // Act
            var startTime = DateTime.UtcNow;
            
            for (int i = 0; i < numberOfRequests; i++)
            {
                tasks[i] = _client.GetAsync(endpoint);
            }

            await Task.WhenAll(tasks);
            var endTime = DateTime.UtcNow;
            var totalTime = endTime - startTime;

            // Assert
            Assert.True(totalTime.TotalSeconds < 5, $"Performance test failed: {numberOfRequests} requests took {totalTime.TotalSeconds} seconds");
            
            foreach (var task in tasks.Cast<Task<HttpResponseMessage>>())
            {
                Assert.Equal(HttpStatusCode.OK, task.Result.StatusCode);
            }
        }
    }
}