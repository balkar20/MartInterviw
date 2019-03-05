using System.Web.Mvc;

namespace ActionFilters.Filters
{
    public class MyActionAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("From action Executing");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Result = new EmptyResult();
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("From result Executing");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("From result Executed");
        }
    }
}