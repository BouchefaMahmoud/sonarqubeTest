using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Moq;

using MyApi.Controllers;
using Xunit;

namespace MyApi.Tests.ControllerTests;

public class WeatherControllerTests
{
  private Mock<ILogger<WeatherForecastController>> _mockLogger = new();
  
  [Fact]
  public void GetWeatherForecast_ReturnsWeatherForecast()
  {
    var controller = new WeatherForecastController(_mockLogger.Object);
    var result = controller.Get();
    Assert.NotNull(result);
  }
  
  [Fact]
  public void GetWeatherForecast_ReturnsWeatherForecastWithFiveItems()
  {
    var controller = new WeatherForecastController(_mockLogger.Object);
    var result = controller.Get();
    Assert.Equal(5, result.Count());
  }
  
}