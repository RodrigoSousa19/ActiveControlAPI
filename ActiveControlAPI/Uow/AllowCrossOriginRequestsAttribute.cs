using Microsoft.AspNetCore.Mvc.Filters;

namespace ActiveControlAPI.Uow
{
    public class AllowCrossOriginRequestsAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            base.OnActionExecuting(context);
        }
    }
}
