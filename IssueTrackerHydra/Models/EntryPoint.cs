using Hydra.Annotations;
using JsonLD.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace IssueTrackerHydra.Models
{
    [SupportedClass(TermConstants.Example + "EntryPoint")]
    [Description("The entry point of the app.")]
    public class EntryPoint
    {

        private const string TestContext = @"
{
    '@vocab': 'http://example.org/Example.owl#' ,
    'issues': 'hasIssue'
}
";

        [JsonProperty]
        private string Type
        {
            get { return TermConstants.Example + "EntryPoint"; }
        }

        public static JToken Context
        {
            get
            {
                return JObject.Parse(TestContext);
            }
        }

        public string Id { get; set; }

        [JsonProperty("issues")]
        public IriRef Issues { get; set; }
    }
}
