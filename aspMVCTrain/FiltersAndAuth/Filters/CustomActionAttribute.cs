using System.Web.Mvc;

namespace mvc1.Filters
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //filterContext.ActionDescriptor
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new System.NotImplementedException();
        }
    }
}