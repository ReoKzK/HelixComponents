namespace HelixComponents.Feature.Notifications.ViewModels
{
    public class NotificationViewModel
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public string CtaConfirmUrl { get; set; }
        public string CtaConfirmText { get; set; }

        public string CtaDeclineUrl { get; set; }
        public string CtaDeclineText { get; set; }
    }
}