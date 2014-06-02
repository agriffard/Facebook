using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Environment.Extensions;
using Orchard.Localization;

namespace Facebook.Drivers {
    [OrchardFeature("Facebook")]
    public class FacebookSettingsPartDriver : ContentPartDriver<FacebookSettingsPart> {
        protected override string Prefix {
            get { return "FacebookSettings"; }
        }

        public FacebookSettingsPartDriver() {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        protected override DriverResult Editor(FacebookSettingsPart part, dynamic shapeHelper) {
            return Editor(part, null, shapeHelper);
            //return ContentShape("Parts_Facebook_SiteSettings",
            //                   () => shapeHelper.EditorTemplate(
            //                       TemplateName: "Parts/Facebook.SiteSettings",
            //                       Model: part,
            //                       Prefix: Prefix))
            //                      .OnGroup("facebook");
        }

        protected override DriverResult Editor(FacebookSettingsPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}