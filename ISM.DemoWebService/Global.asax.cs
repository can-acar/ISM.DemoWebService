using System;
using System.ServiceModel.Security;
using Autofac.Integration.Wcf;
using ISM.Demo.Configrations;

namespace ISM.Demo
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AutofacHostFactory.Container = HostConfigration.SetContainer();
            
            
        }
    }
}