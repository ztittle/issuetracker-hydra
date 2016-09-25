using IssueTrackerHydra.Models;
using JsonLD.Entities;

namespace IssueTrackerHydra.Modules
{
    public class EntryPointModule : Nancy.NancyModule
    {
        public EntryPointModule()
        {
            Get["/entrypoint"] = _ => new EntryPoint { Id = Request.Url, Issues = (IriRef)"/issues" };
        }
    }
}