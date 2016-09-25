using System;
using Microsoft.Owin;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Owin;
using TestNancyApp;

[assembly: OwinStartup(typeof(Startup))]

namespace TestNancyApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy(options => options.Bootstrapper = new TestBootstrapper());
        }

        public class TestBootstrapper : DefaultNancyBootstrapper
        {
            protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
            {
                //CORS Enable
                pipelines.AfterRequest.AddItemToEndOfPipeline((ctx) =>
                {
                    ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                                    .WithHeader("Access-Control-Allow-Methods", "POST,PUT,DELETE,GET")
                                    .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type")
                                    .WithHeader("Access-Control-Expose-Headers", "Link");

                });
            }

            protected override void ConfigureApplicationContainer(TinyIoCContainer container)
            {
                // don't call base to disable automatic registration
            }
        }
    }
}