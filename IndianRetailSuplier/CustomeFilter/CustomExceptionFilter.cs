using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IndianRetailSuplier.CustomeFilter
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IModelMetadataProvider _modelMetadataProvider;

        public CustomExceptionFilter(IModelMetadataProvider modelMetadataProvider)
        {
            _modelMetadataProvider = modelMetadataProvider;
        }

        public void OnException(ExceptionContext context)
        {

            //HandleExceptionAsync(context);
            //context.ExceptionHandled = true;


            //var statuscode = context.HttpContext.Response.StatusCode;
            //var exception = context.Exception;
            var result = new ViewResult { ViewName = "CustomError" };
            result.ViewData = new ViewDataDictionary(_modelMetadataProvider, context.ModelState);
            result.ViewData.Add("Exception", context.Exception);

            // Here we can pass additional detailed data via ViewData
            context.ExceptionHandled = true; // mark exception as handled
            context.Result = result;
        }

        //private static void HandleExceptionAsync(ExceptionContext context)
        //{
        //    var exception = context.Exception;

        //    if (exception is MyNotFoundException)
        //        SetExceptionResult(context, exception, HttpStatusCode.NotFound);
        //    else if (exception is MyUnauthorizedException)
        //        SetExceptionResult(context, exception, HttpStatusCode.Unauthorized);
        //    else if (exception is MyException)
        //        SetExceptionResult(context, exception, HttpStatusCode.BadRequest);
        //    else
        //        SetExceptionResult(context, exception, HttpStatusCode.InternalServerError);
        //}

        //private static void SetExceptionResult(ExceptionContext context,Exception exception,HttpStatusCode code)
        //{
        //    context.Result = new JsonResult(new ApiResponse(exception))
        //    {
        //        StatusCode = (int)code
        //    };
        //}
    }
}
