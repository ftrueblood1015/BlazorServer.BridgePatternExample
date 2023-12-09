using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Infrastructure;

namespace BlazorServer.BridgePatternExample.Repositories.Conditions
{
    public class ConditionRepository : BaseRepository<Condition, BridgePatternContext>, IConditionRepository
    {
        public ConditionRepository(BridgePatternContext context) : base(context)
        {
        }
    }
}
