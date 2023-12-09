using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Infrastructure;

namespace BlazorServer.BridgePatternExample.Repositories.ColorIdentities
{
    public class ColorIdentityRepository : BaseRepository<ColorIdentity, BridgePatternContext>, IColorIdentityRepository
    {
        public ColorIdentityRepository(BridgePatternContext context) : base(context)
        {
        }
    }
}
