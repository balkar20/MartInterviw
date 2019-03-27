

using System.Globalization;
using System.Web;
using System.Web.Mvc;

namespace FiltersAndAuth.Providers
{
    public class BrowserValueProvider : IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return string.Compare("browser", prefix, true) == 0;
        }

        public System.Web.Mvc.ValueProviderResult GetValue(string key)
        {
            return ContainsPrefix(key) ? new ValueProviderResult("Ваш браузер: " + HttpContext.Current.Request.Browser.Browser, null,
                CultureInfo.InvariantCulture) : null;
        }
    }

    public class BrowserValueProviderFactory : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            return new BrowserValueProvider();
        }
    }

}