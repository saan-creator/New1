using NUnit.Framework;

namespace SampleAPI.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            SimpleAPI.Controllers.WeatherForecastController p = new SimpleAPI.Controllers.WeatherForecastController(null);
            Assert.AreEqual(15, p.Add(5, 5));
        }

    }
}
