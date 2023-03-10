using Domain.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Task.Rest.Api.Filters
{
    public class ActioFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
