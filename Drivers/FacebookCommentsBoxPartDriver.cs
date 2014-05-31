using System;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment.Extensions;
using Facebook.Models;
using Facebook.Settings;

namespace Facebook.Drivers {
    [OrchardFeature("Facebook.CommentsBox")]
    public class FacebookCommentsBoxPartDriver : ContentPartDriver<FacebookCommentsBoxPart> {
        protected override string Prefix {
            get { return "FacebookCommentsBox"; }
        }

        protected override DriverResult Display(FacebookCommentsBoxPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_FacebookCommentsBox",
                () => {
                        var settings = part.TypePartDefinition.Settings.GetModel<FacebookCommentsBoxPartSettings>();
                        return shapeHelper.Parts_FacebookCommentsBox(Width: settings.Width,
                                                                ColorScheme: settings.ColorScheme,
                                                                NumberOfPosts: settings.NumberOfPosts,
                                                                OrderBy: settings.OrderBy);
                });
        }

        // GET
        protected override DriverResult Editor(FacebookCommentsBoxPart part, dynamic shapeHelper) {
            return ContentShape("Parts_FacebookCommentsBox_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/Facebook/FacebookCommentsBox",
                    Model: part,
                    Prefix: Prefix));
        }

        // POST
        protected override DriverResult Editor(FacebookCommentsBoxPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override void Exporting(FacebookCommentsBoxPart part, ExportContentContext context) {
            context.Element(part.PartDefinition.Name).SetAttributeValue("CommentsShown", part.Record.CommentsShown);
        }

        protected override void Importing(FacebookCommentsBoxPart part, ImportContentContext context) {
            part.Record.CommentsShown = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "CommentsShown"));
        }
    }
}