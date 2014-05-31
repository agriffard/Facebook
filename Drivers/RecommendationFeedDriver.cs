using System;
using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment.Extensions;

namespace Facebook.Drivers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class RecommendationFeedDriver : ContentPartDriver<RecommendationFeedPart> {
        protected override string Prefix {
            get {
                return "recommendationfeed";
            }
        }

        protected override DriverResult Display(RecommendationFeedPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_RecommendationFeed",
                                () => shapeHelper.Parts_RecommendationFeed(Site: part.Site,
                                                                Width: part.Width,
                                                                Height: part.Height,
                                                                MaxAge: part.MaxAge,
                                                                ColorScheme: part.ColorScheme,
                                                                ShowHeader: part.ShowHeader,
                                                                Actions: part.Actions,
                                                                Ref: part.Ref,
                                                                AppId: part.AppId));
        }

        //GET
        protected override DriverResult Editor(RecommendationFeedPart part, dynamic shapeHelper) {
            return ContentShape("Parts_RecommendationFeed_Edit",
                                () => shapeHelper.EditorTemplate(
                                    TemplateName: "Parts/Facebook/RecommendationFeed",
                                    Model: part,
                                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(RecommendationFeedPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override void Exporting(RecommendationFeedPart part, ExportContentContext context) {
            context.Element(part.PartDefinition.Name).SetAttributeValue("Site", part.Record.Site);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Width", part.Record.Width);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Height", part.Record.Height);
            context.Element(part.PartDefinition.Name).SetAttributeValue("MaxAge", part.Record.MaxAge);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ColorScheme", part.Record.ColorScheme);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ShowHeader", part.Record.ShowHeader);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Actions", part.Record.Actions);
            context.Element(part.PartDefinition.Name).SetAttributeValue("AppId", part.Record.AppId);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Ref", part.Record.Ref);
        }

        protected override void Importing(RecommendationFeedPart part, ImportContentContext context) {
            part.Record.Site = context.Attribute(part.PartDefinition.Name, "Site");
            part.Record.Width = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "Width"));
            part.Record.Height = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "Height"));
            part.Record.MaxAge = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "MaxAge"));
            part.Record.ColorScheme = context.Attribute(part.PartDefinition.Name, "ColorScheme");
            part.Record.ShowHeader = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ShowHeader"));
            part.Record.Actions = context.Attribute(part.PartDefinition.Name, "Actions");
            part.Record.AppId = context.Attribute(part.PartDefinition.Name, "AppId");
            part.Record.Ref = context.Attribute(part.PartDefinition.Name, "Ref");
        }
    }
}