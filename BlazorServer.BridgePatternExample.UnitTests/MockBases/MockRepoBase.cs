using BlazorServer.BridgePatternExample.Domain.Models;
using Moq;
using System.Text;
using BlazorServer.BridgePatternExample.Repositories;

namespace BlazorServer.BridgePatternExample.UnitTests.MockBases
{
    public static class MockRepoBase
    {
        public static Mock<TRepo> MockRepo<TRepo, T>(IEnumerable<T> list)
            where TRepo : class, IBaseRepository<T>
            where T : BaseModel
        {
            var mock = new Mock<TRepo>();

            mock.Setup(x => x.Add(It.IsAny<T>())).Returns((T x) =>
            {
                x.Id = list.Count() + 1;
                list.Append(x);
                return x;
            });

            mock.Setup(x => x.GetById(It.IsAny<int>())).Returns((int x) => { return list.FirstOrDefault(y => y.Id == x); });

            return mock;
        }
    }
}
