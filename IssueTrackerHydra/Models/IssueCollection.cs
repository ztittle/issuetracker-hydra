using Hydra.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace IssueTrackerHydra.Models
{
    [SupportedClass("http://example.api/o#IssueCollection")]
    [Description("The collection of issues")]
    public class IssueCollection
    {
        private const string TestContext = @"
{
    '@vocab': 'http://example.org/Example.owl#' ,
    'members': {
        '@id': 'http://www.w3.org/ns/hydra/core#member',
        '@type': '@id'
    }
}
";

        [JsonProperty]
        private string Type
        {
            get { return "http://example.api/o#IssueCollection"; }
        }

        public static JToken Context
        {
            get
            {
                return JObject.Parse(TestContext);
            }
        }

        public string Id { get; set; }

        public string[] Members { get; set; }
    }
}