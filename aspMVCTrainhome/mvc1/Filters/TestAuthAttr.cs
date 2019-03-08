using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace mvc1.Filters
{
    public class TestAuthAttr : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            throw new System.NotImplementedException();
        }
    }
}