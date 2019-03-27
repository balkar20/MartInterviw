using System.Web;
using System.Web.Mvc;

namespace mvc1.Filters
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return false;
        }
    }
}