using System;
using Nancy;
using System.Collections.Generic;
using System.Linq;
using Nancy.ModelBinding;
using IssueTrackerHydra.Models;

namespace IssueTrackerHydra.Modules
{
    public class IssuesModule : NancyModule
    {
        public static Dictionary<string, Issue> issues = new Dictionary<string, Issue>();
        public static int counter = 0;

        public IssuesModule() : base("issues")
        {
            Post[""] = _ =>
            {
                var issue = this.Bind<Issue>();

                issue.Id = $"/issues/id/{counter++}";

                issues.Add(issue.Id, issue);
                return Negotiate.WithModel(issue)
                .WithStatusCode(HttpStatusCode.Created)
                .WithHeader("Location", new Uri(Request.Url, issue.Id).AbsoluteUri);
            };

            Get[""] = _ => new IssueCollection
            {
                Id = Request.Url,
                Members = issues.Values.Select(i => i.Id).ToArray()
            };

            Get["id/{id}"] = _ => issues.ContainsKey(Request.Url.Path) ? issues[Request.Url.Path] : (object)HttpStatusCode.NotFound;
            
            Delete["id/{id}"] = _ =>
            {
                if (!issues.ContainsKey(Request.Url.Path))
                {
                    return HttpStatusCode.NotFound;
                }

                issues.Remove(Request.Url.Path);
                return HttpStatusCode.OK;
            };
        }
    }
}