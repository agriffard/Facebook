using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Localization;

namespace Facebook.Drivers {
    public class FacebookSettingsPartDriver : ContentPartDriver<FacebookSettingsPart> {
        public FacebookSettingsPartDriver() {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        protected override string Prefix { get { return "FacebookSettings"; } }

        protected override DriverResult Editor(FacebookSettingsPart part, dynamic shapeHelper) {
            return ContentShape("Parts_Facebook_SiteSettings",
                               () => shapeHelper.EditorTemplate(TemplateName: "Parts.Facebook.SiteSettings", Model: part.Record, Prefix: Prefix));
        }

        protected override DriverResult Editor(FacebookSettingsPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part.Record, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}