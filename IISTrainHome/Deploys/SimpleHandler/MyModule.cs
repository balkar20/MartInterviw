using System.Web;

namespace SimpleHandler
{
    public class MyModule: IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.PreRequestHandlerExecute += Context_PreRequestHandlerExecute;
        }

        private void Context_PreRequestHandlerExecute(object sender, System.EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Cookies["testModule"].Value = "testModule value";
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}