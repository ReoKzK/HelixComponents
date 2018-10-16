using System.Web.Mvc;
using HelixComponents.Feature.Tabs.Factories;
using Sitecore.Mvc.Controllers;

namespace HelixComponents.Feature.Tabs.Controllers
{
    public class TabsController : SitecoreController
    {
        private readonly ITabFactory _tabFactory;

        public TabsController(ITabFactory tabFactory)
        {
            _tabFactory = tabFactory;
        }

        public ActionResult Tabs()
        {
            var viewModel = _tabFactory.CreateViewModel();

            // TODO
            //return ComponentView(viewModel, settings =>
            //{
            //    settings.TemplateView = viewModel.RenderingParameters.TemplateView;

            //    return settings;
            //});

            return View();
        }
    }
}