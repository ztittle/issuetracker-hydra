using System.Collections.Generic;
using System.Reflection;
using Hydra.Discovery.SupportedClasses;
using IssueTrackerHydra.Models;

namespace IssueTrackerHydra.Hydra
{
    public class AssembliesToScanForSupportedTypes : AssemblyAnnotatedTypeSelector
    {
        protected override IEnumerable<Assembly> Assemblies
        {
            get { yield return typeof (Issue).Assembly; }
        }
    }
}