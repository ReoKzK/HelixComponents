using HelixComponents.Foundation.ORM.Models;

namespace HelixComponents.Foundation.Content.Tests.Models
{
    public interface ITestItem : IGlassBase
    {
        string Title { get; set; }
    }
}
