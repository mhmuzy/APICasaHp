using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Projeto.Application.ApplicationServices.Contracts;
using Projeto.Application.ApplicationServices.Implementation;
using Projeto.Domain.Clientes.DomainServices.Contarcts;
using Projeto.Domain.Clientes.DomainServices.Implementation;
using Projeto.Domain.Clientes.Infra.Messages;
using Projeto.Domain.Clientes.Infra.Repositories;
using Projeto.Infra.Messages;
using Projeto.Infra.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using Projeto.Infra.Repositories.Persistence;

namespace Projeto.Presentation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            /// Create the container as usual
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            /// Register your types, for instance using the scoped lifestyle:
            container.Register<IAppServiceCliente, ClienteAppAervice>(Lifestyle.Scoped);

            container.Register<IClienteDomainService, ClienteDomainService>(Lifestyle.Scoped);

            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);

            container.Register<IEmailMessages, EmailMessage>(Lifestyle.Scoped);

            /// This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container); 

        }
    }
}
