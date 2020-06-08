using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Tests;

namespace MediatorCQRSTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Helper.Init();
        }

        [Test]
        public async Task Welcome_get_should_return_welcome_message()
        {
            // act
            var response = await Helper.Get("/api/welcome");

            // assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var responseContent = await response.Content.ReadAsStringAsync();
            responseContent.Should().Be("Welcome stranger");
            //
        }
    }
}