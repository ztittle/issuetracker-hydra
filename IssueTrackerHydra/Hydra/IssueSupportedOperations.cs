using Hydra.Discovery.SupportedOperations;
using IssueTrackerHydra.Models;
using Nancy.Security;
using TestNancyApp.Bootstrap;

namespace IssueTrackerHydra.Hydra
{
    public class IssueSupportedOperations : SupportedOperations<Issue>
    {
        public IssueSupportedOperations(NancyContextWrapper current)
        {
            Class.SupportsGet();

            if (current.Context.CurrentUser.HasClaim("Admin"))
            {
                Class.SupportsDelete();
            }
        }
    }
}