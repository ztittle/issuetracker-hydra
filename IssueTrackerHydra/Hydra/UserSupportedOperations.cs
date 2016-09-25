using Hydra.Discovery.SupportedOperations;
using IssueTrackerHydra.Models;

namespace IssueTrackerHydra.Hydra
{
    public class UserSupportedOperations : SupportedOperations<User>
    {
        public UserSupportedOperations()
        {
            Class.SupportsGet();
        }
    }
}