using JetBrains.Annotations;
using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Orchard.Localization;

namespace Facebook.Handlers {
    [OrchardFeature("Facebook")]
    public class FacebookSettingsPartHandler : ContentHandler {
        public FacebookSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<FacebookSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<FacebookSettingsPart>("SiteSettings", "Parts/Facebook.SiteSettings", "facebook"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Facebook")));
        }
    }
}