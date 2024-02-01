
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Data.SqlTypes;
namespace TourProject.Filtros
{
    public class LogActionFilterAttribute:ActionFilterAttribute
    {
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
        private string _contentRoothPath;
        private string _logPath;
        private string _fileName;
        private string _fullPath;

        public LogActionFilterAttribute(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _environment = environment;
            _contentRoothPath = _environment.ContentRootPath;
            _logPath = _contentRoothPath + "\\LogFile\\";
            _fileName = $"log {DateTime.Now.ToString("MM-dd-yyyy-H-mm")}.txt";
            _fullPath = _logPath + _fileName;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Directory.CreateDirectory(_logPath);
            string actionName = context.ActionDescriptor.RouteValues["action"];
            string controllerName = context.ActionDescriptor.RouteValues["controller"];
            using (FileStream fs = new FileStream(_fullPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"La accion {actionName} el controlador {controllerName} inició, evento: OnActionExecuting");
                }
            }     
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //Directory.CreateDirectory(_logPath);
            string actionName = context.ActionDescriptor.RouteValues["action"];
            string controllerName = context.ActionDescriptor.RouteValues["controller"];
            using (FileStream fs = new FileStream(_fullPath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"La accion {actionName} el controlador {controllerName} finalizó, evento: OnActionExecuted");
                }
            }
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            //Directory.CreateDirectory(_logPath);
            string actionName = context.ActionDescriptor.RouteValues["action"];
            string controllerName = context.ActionDescriptor.RouteValues["controller"];
            ViewResult resultado = (ViewResult)context.Result;
            using (FileStream fs = new FileStream(_fullPath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"La accion {actionName} el controlador {controllerName} tiene el viewData: {resultado.ViewData.Values.FirstOrDefault()}, evento: OnResultExecuted");
                }
            }
        }
    }
}
