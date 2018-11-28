using Glass.Mapper.Sc.Fields;
using HelixComponents.Foundation.ORM.Models;

namespace HelixComponents.Feature.Notifications.Models
{
    public interface INotification : IGlassBase
    {
        string Title { get; set; }
        string Message { get; set; }

        Link CtaConfirm { get; set; }
        string CtaConfirmText { get; set; }

        Link CtaDecline { get; set; }
        string CtaDeclineText { get; set; }
    }
}