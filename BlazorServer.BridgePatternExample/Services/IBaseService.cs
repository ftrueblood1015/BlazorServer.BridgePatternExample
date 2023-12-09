using BlazorServer.BridgePatternExample.Domain.Models;

namespace BlazorServer.BridgePatternExample.Services
{
    public interface IBaseService<T> where T : BaseModel
    {
        T Add(T entity);

        bool Delete(T entity);

        bool DeleteById(int entityId);

        IEnumerable<T> Filter(Func<T, bool> predicate);

        IEnumerable<T> GetAll();

        T? GetById(int id);

        T Update(T entity);
    }
}
