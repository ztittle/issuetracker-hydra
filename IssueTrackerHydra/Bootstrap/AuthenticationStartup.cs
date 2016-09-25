using System;
using System.Collections.Generic;
using Nancy.Bootstrapper;
using Nancy.Security;

namespace TestNancyApp.Bootstrap
{
    public class AuthenticationStartup : IApplicationStartup
    {
        public void Initialize(IPipelines pipelines)
        {
        }

        public class TestUser : IUserIdentity
        {
            public TestUser(string userName)
            {
                UserName = userName;
                Claims = new[]
                {
                    userName
                };
            }

            public string UserName { get; }

            public IEnumerable<string> Claims { get; }
        }
    }
}