using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Template.Components.Widgets.WidgetNameWidget
{
    public class WidgetNameViewComponent : BaseWidgetComponent<WidgetNameProperties>
    {
        public const string IDENTIFIER = "Template.Components.Widgets.WidgetName";

        public WidgetNameViewComponent()
        {
            // inject your services here
        }
        public override ViewViewComponentResult Invoke(WidgetNameProperties properties)
        {
            return WidgetView("~/Components/Widgets/WidgetNameWidget", new WidgetNameViewModel
            {
                // map your properties to the view model
                // e.g.
                // MyProperty = properties.MyProperty
            });
        }
    }
}
