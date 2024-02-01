using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Filtros.Filters
{
	public class CustomActionFilter: ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			//base.OnActionExecuting(context);
			string actionName = context.ActionDescriptor.RouteValues["action"];
			Debug.WriteLine(">>>"+actionName+"started, evet fired: OnActionExecuting");
		}
		public override void OnActionExecuted(ActionExecutedContext context)
		{
			string actionName = context.ActionDescriptor.RouteValues["action"];
			Debug.WriteLine(">>>" + actionName + "finished, evet fired: OnActionExecuted");
		}
		public override void OnResultExecuting(ResultExecutingContext context)
		{
			string actionName = context.ActionDescriptor.RouteValues["action"];
			Debug.WriteLine(">>>" + actionName + " before results, evet fired: OnResultExecuting");
		}
		public override void OnResultExecuted(ResultExecutedContext context)
		{
			string actionName = context.ActionDescriptor.RouteValues["action"];
			ContentResult result = (ContentResult)context.Result; 
			Debug.WriteLine(">>>" + actionName + " results: " + result +" evet fired: OnResultExecuted");
		}
	}
}
