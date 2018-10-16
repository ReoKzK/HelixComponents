using HelixComponents.Foundation.ORM.Models;
using System.Collections.Generic;

namespace HelixComponents.Feature.Redirects.Models
{
    public interface IRedirectFolder : IGlassBase
    {
        IEnumerable<I301Redirect> Children { get; set; }
    }
}
