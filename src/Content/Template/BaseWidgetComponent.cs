using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace Template.Components.Widgets
{
    public abstract class BaseWidgetComponent<TModel> : ViewComponent
    {
        public bool IsEditMode => HttpContext.Kentico().PageBuilder().EditMode;
        public ViewViewComponentResult WidgetView<TWidgetModel>(string componentFolderPath, TWidgetModel viewModel)
        {
            if (IsEditMode)
            {
                return View($"{componentFolderPath.TrimEnd('/')}/_Admin.cshtml", viewModel);
            }

            return View($"{componentFolderPath.TrimEnd('/')}/_Public.cshtml", viewModel);
        }
        public abstract ViewViewComponentResult Invoke(TModel properties);
    }
}
