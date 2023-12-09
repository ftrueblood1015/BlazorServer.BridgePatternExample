using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Services;
using Moq;

namespace BlazorServer.BridgePatternExample.UnitTests.MockBases
{
    public static class MockServiceBase
    {
        public static Mock<TService> MockService<TService, T>()
            where TService : class, IBaseService<T>
            where T : BaseModel
        {
            var mock = new Mock<TService>();

            mock.Setup(x => x.Add(It.IsAny<T>())).Returns((T x) => x);

            return mock;
        }
    }
}
