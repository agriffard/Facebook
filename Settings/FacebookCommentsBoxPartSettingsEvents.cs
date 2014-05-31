using System.Collections.Generic;
using System.Globalization;
using Orchard.ContentManagement;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.ContentManagement.ViewModels;
using Orchard.Localization;

namespace Facebook.Settings {
    public class FacebookCommentsBoxPartSettingsEvents : ContentDefinitionEditorEventsBase {

        public Localizer T { get; set; }

        public override IEnumerable<TemplateViewModel> TypePartEditor(ContentTypePartDefinition definition) {
            if (definition.PartDefinition.Name != "FacebookCommentsBoxPart")
                yield break;

            var settings = definition.Settings.GetModel<FacebookCommentsBoxPartSettings>();

            yield return DefinitionTemplate(settings);
        }

        public override IEnumerable<TemplateViewModel> TypePartEditorUpdate(ContentTypePartDefinitionBuilder builder, IUpdateModel updateModel) {
            if (builder.Name != "FacebookCommentsBoxPart")
                yield break;

            var settings = new FacebookCommentsBoxPartSettings {
            };

            if (updateModel.TryUpdateModel(settings, "FacebookCommentsBoxPartSettings", null, null)) {
                builder.WithSetting("FacebookCommentsBoxPartSettings.Width", settings.Width.ToString(CultureInfo.InvariantCulture));
                builder.WithSetting("FacebookCommentsBoxPartSettings.NumberOfPosts", settings.NumberOfPosts.ToString(CultureInfo.InvariantCulture));
                builder.WithSetting("FacebookCommentsBoxPartSettings.ColorScheme", settings.ColorScheme);
                builder.WithSetting("FacebookCommentsBoxPartSettings.OrderBy", settings.OrderBy);
            }

            yield return DefinitionTemplate(settings);
        }
    }
}
