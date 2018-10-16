using HelixComponents.Foundation.ORM.Models;

namespace HelixComponents.Feature.Redirects.Models
{
    public interface I301Redirect : IGlassBase
    {
        string RequestedUrl { get; set; }
        IGlassBase RedirectItem { get; set; }
    }
}
