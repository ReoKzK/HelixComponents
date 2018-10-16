using System;
using System.Web;

namespace HelixComponents.Feature.Tabs.ViewModels
{
    public class TabItemViewModel
    {
        public Guid Id { get; set; }
        public HtmlString Title { get; set; }
        public string ActiveClass { get; set; }
        public string CampaignCategoriesAttr { get; set; }
    }
}