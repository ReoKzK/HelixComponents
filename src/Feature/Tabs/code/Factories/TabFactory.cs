using System.Linq;
using System.Web;
using Glass.Mapper.Sc;
using HelixComponents.Feature.Tabs.ViewModels;
using HelixComponents.Foundation.Content.Repositories;

namespace HelixComponents.Feature.Tabs.Factories
{
    public class TabFactory : ITabFactory
    {
        private readonly IRenderingRepository _renderingRepository;
        private readonly IGlassHtml _glassHtml;

        public TabsViewModel CreateViewModel()
        {
            // TODO

            ////var test = _datasourceRepository.GetRenderingParameters<ITabsRp>().TemplateId;

            //// TODO: Refactor get component method to an injected component factory
            //var component = GetComponent();

            //component.IsInExperienceEditorMode = _datasourceRepository.IsExperienceEditor;
            ////TODO: Refactor to a site setting
            //component.ContainsMinimumTabs = component.ComponentModel.Children.Count() >= 2;

            //foreach (var tabItem in component.ComponentModel.Children)
            //{
            //    component.TabItems.Add(new TabItemViewModel
            //    {
            //        Id = tabItem.Id,
            //        Title = new HtmlString(_glassHtml.Editable(tabItem, i => i.Title))
            //    });
            //}
            
            //if (component.TabItems.Count() >= 1)
            //{
            //    component.TabItems.First().ActiveClass = "active";
            //}

            //return component;

            return new TabsViewModel();
        }
    }
}