using Microsoft.AspNetCore.Mvc;
using TestVibeAgent.Controllers;
using Xunit;

namespace TestVibeAgent.Tests
{
    /// <summary>
    /// Tests unitaires pour le contrôleur Ping
    /// </summary>
    public class PingControllerTests
    {
        private readonly PingController _controller;

        public PingControllerTests()
        {
            _controller = new PingController();
        }

        /// <summary>
        /// Test que l'endpoint ping retourne une réponse OK
        /// </summary>
        [Fact]
        public void Ping_ShouldReturnOkResult()
        {
            // Act
            var result = _controller.Ping();

            // Assert
            Assert.IsType<ActionResult<string>>(result);
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal(200, okResult.StatusCode);
        }

        /// <summary>
        /// Test que l'endpoint ping retourne exactement "pong"
        /// </summary>
        [Fact]
        public void Ping_ShouldReturnPongString()
        {
            // Act
            var result = _controller.Ping();

            // Assert
            Assert.IsType<ActionResult<string>>(result);
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal("pong", okResult.Value);
        }

        /// <summary>
        /// Test que l'endpoint ping n'est jamais null
        /// </summary>
        [Fact]
        public void Ping_ShouldNeverReturnNull()
        {
            // Act
            var result = _controller.Ping();

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Result);
            
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            Assert.NotNull(okResult.Value);
        }

        /// <summary>
        /// Test que l'endpoint ping retourne toujours le même résultat (idempotence)
        /// </summary>
        [Fact]
        public void Ping_ShouldBeIdempotent()
        {
            // Act
            var result1 = _controller.Ping();
            var result2 = _controller.Ping();

            // Assert
            var okResult1 = Assert.IsType<OkObjectResult>(result1.Result);
            var okResult2 = Assert.IsType<OkObjectResult>(result2.Result);
            
            Assert.Equal(okResult1.Value, okResult2.Value);
            Assert.Equal(okResult1.StatusCode, okResult2.StatusCode);
        }

        /// <summary>
        /// Test de performance basique - l'appel doit être rapide
        /// </summary>
        [Fact]
        public void Ping_ShouldExecuteQuickly()
        {
            // Arrange
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            // Act
            var result = _controller.Ping();

            // Assert
            stopwatch.Stop();
            Assert.True(stopwatch.ElapsedMilliseconds < 100, 
                $"L'endpoint ping a pris {stopwatch.ElapsedMilliseconds}ms, ce qui est trop lent");
            
            // Vérifier que le résultat est correct
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal("pong", okResult.Value);
        }
    }
}