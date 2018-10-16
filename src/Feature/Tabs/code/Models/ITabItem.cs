using HelixComponents.Foundation.ORM.Models;

namespace HelixComponents.Feature.Tabs.Models
{
    public interface ITabItem : IGlassBase
    {
        string Title { get; set; }
    }
}
