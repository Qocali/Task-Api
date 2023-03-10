using Domain.Domain.Entities;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Task.Rest.Api.Middlewares
{
    public class ApplicationMiddleware : IMiddleware
    {
        public async System.Threading.Tasks.Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //var body = context.Request.Body;
            //if (body == null)
            //{
            //    //excepciton response
            //    var statuscode = StatusCodes.Status500InternalServerError;
            //    var response = new Response { StatusCode = statuscode, Message = "have any error in your code" };
            //    await context.Response.WriteAsJsonAsync(response);
            //}
            await next(context);

        }
    }
}
