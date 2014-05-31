using System.Collections.Generic;
using Facebook.Models;
using Orchard;
using Orchard.ContentManagement;
using Orchard.Localization;
using Orchard.Messaging.Services;
using Orchard.UI.Admin.Notification;
using Orchard.UI.Notify;

namespace Facebook.Services {
    //public class MissingSettingsBanner : INotificationProvider {
    //    private readonly IOrchardServices _orchardServices;

    //    public MissingSettingsBanner(IOrchardServices orchardServices) {
    //        _orchardServices = orchardServices;
    //        T = NullLocalizer.Instance;
    //    }

    //    public Localizer T { get; set; }

    //    public IEnumerable<NotifyEntry> GetNotifications() {

    //        var facebookSettings = _orchardServices.WorkContext.CurrentSite.As<FacebookSettingsPart>();

    //        if (facebookSettings != null && (string.IsNullOrEmpty(facebookSettings.AppId) || string.IsNullOrEmpty(facebookSettings.AppSecret))) {
    //            yield return new NotifyEntry { Message = T("Facebook settings need to be set."), Type = NotifyType.Warning };
    //        }
    //    }
    //}
}
