using Hydra;
using Hydra.Discovery.SupportedOperations;
using IssueTrackerHydra.Hydra;
using Nancy.Bootstrapper;

namespace TestNancyApp.Bootstrap
{
    public class HydraRegistrations : Registrations
    {
        public HydraRegistrations()
        {
            Register<IHydraDocumentationSettings>(new HydraDocumentationSettings());

            // todo: move to Lernaean.Hydra.Nancy when bug NancyFx/Nancy#2384 is fixed
            RegisterAll<ISupportedOperations>(Lifetime.PerRequest);
        }
    }
}