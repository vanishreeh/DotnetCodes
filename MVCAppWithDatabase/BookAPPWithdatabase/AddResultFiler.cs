using Microsoft.AspNetCore.Mvc.Filters;

namespace BookAPPWithdatabase
{
    public class AddResultFiler : ResultFilterAttribute {
        //public class AddResultFiler : IResultFilter
        //{
        //    public void OnResultExecuted(ResultExecutedContext context)
        //    {

        //    }

        //    public void OnResultExecuting(ResultExecutingContext context)
        //    {
        //        context.HttpContext.Response.Headers.Add(
        //            "BookContextId",
        //            "This result is added via resultFilter"
        //            );
        //    }
        //public override void OnResultExecuted(ResultExecutingContext context)
        //{
        //    base.OnResultExecuting(context);
        //}
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(
                    "BookContextId",
                    "This result is added via resultFilter"
                    );
        }
    }
}
