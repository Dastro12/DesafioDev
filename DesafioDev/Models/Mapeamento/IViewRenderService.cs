using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDev.Models.Service.Interface
{
    public interface IViewRenderService
    {
        string RenderToString(Controller controller, [AspMvcPartialView] string viewName, object viewModel);
    }
}
