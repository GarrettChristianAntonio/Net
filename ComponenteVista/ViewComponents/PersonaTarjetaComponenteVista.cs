using Microsoft.AspNetCore.Mvc;
namespace ComponenteVista.ViewComponents
{
    public class PersonaTarjetaComponenteVista : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(int id)
        {
            return Task.FromResult<IViewComponentResult>(View("Tarjeta", id));
        }
    }
}
