using FakeItEasy;
using NUnit.Framework;
using FluentAssertions;

namespace pcl.fakeiteasy.Test
{
    [TestFixture]
    public class ProviderTest
    {
        private Provider testee;
        private IService service;

        [SetUp]
        public void SetUp()
        {
            this.service = A.Fake<IService>();

            this.testee = new Provider(this.service);
        }

        [Test]
        public void JustFakeIt()
        {
            const string ServiceResult = "the service result";
            A.CallTo(() => this.service.Get()).Returns(ServiceResult);
            var result = this.testee.Provide();

            result.Should().Be(ServiceResult);
        }
    }
}