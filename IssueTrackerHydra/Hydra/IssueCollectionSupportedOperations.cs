using Hydra.Discovery.SupportedOperations;
using IssueTrackerHydra.Models;
using JsonLD.Entities;
using TestNancyApp.Bootstrap;

namespace IssueTrackerHydra.Hydra
{
    public class IssueCollectionSupportedOperations : SupportedOperations<IssueCollection>
    {
        public IssueCollectionSupportedOperations(NancyContextWrapper current)
        {
            Class.SupportsGet();

            Class.SupportsPost("Issue Collection", "Supports the management of issues", (IriRef)"http://example.api/o#Issue", (IriRef)"http://example.api/o#Issue");
        }
    }
}