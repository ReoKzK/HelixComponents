using System.Collections.Generic;

namespace HelixComponents.Feature.Tabs.ViewModels
{
    public class TabsViewModel
    {
        public List<TabItemViewModel> TabItems { get; set; } = new List<TabItemViewModel>();

        public bool IsInExperienceEditorMode { get; set; }
        public bool ContainsMinimumTabs { get; set; }
    }
}