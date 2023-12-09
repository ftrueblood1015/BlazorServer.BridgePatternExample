using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories;
using BlazorServer.BridgePatternExample.Repositories.Conditions;

namespace BlazorServer.BridgePatternExample.Services.Conditions
{
    public class ConditionService : BaseService<Condition, IConditionRepository>, IConditionService
    {
        public ConditionService(IBaseRepository<Condition> repo) : base(repo)
        {
        }
    }
}
