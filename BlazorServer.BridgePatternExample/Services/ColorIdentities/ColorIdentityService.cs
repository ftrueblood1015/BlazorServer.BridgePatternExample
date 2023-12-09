using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories;
using BlazorServer.BridgePatternExample.Repositories.ColorIdentities;

namespace BlazorServer.BridgePatternExample.Services.ColorIdentities
{
    public class ColorIdentityService : BaseService<ColorIdentity, IColorIdentityRepository>, IColorIdentityService
    {
        public ColorIdentityService(IBaseRepository<ColorIdentity> repo) : base(repo)
        {
        }
    }
}
