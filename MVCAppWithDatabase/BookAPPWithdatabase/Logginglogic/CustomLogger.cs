using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookAPPWithdatabase.Logginglogic
{
    public class CustomLogger:ActionFilterAttribute
    {
        readonly string logFileName;
        DateTime startTime;
        DateTime endTime;
        TimeSpan totalTime;
        //constructor
        public CustomLogger(IWebHostEnvironment environment)
        {
            logFileName = environment.ContentRootPath+"/LoggingFile/CustomLogger.txt";
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            startTime = DateTime.Now;
            ControllerBase controllerBase = (ControllerBase)context.Controller;
            ControllerContext controllerContext = controllerBase.ControllerContext;
            string controllerName = controllerContext.ActionDescriptor.ControllerName;
            string actionMethod = controllerContext.ActionDescriptor.ActionName;
            using(StreamWriter writer = File.AppendText(logFileName))
            {
                writer.Write($"StartTime::{startTime}\tController::{controllerName}\tAction::{actionMethod}");
            }
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            endTime = DateTime.Now;
            totalTime = endTime - startTime;
            using (StreamWriter writer = File.AppendText(logFileName))
            {
                writer.WriteLine($"EndTime::{endTime}\tTotal time::{totalTime.TotalSeconds}");
            }

        }


    }
}
