using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class ResultCatcherFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var x = filterContext;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var x = filterContext;
        }
    }
}