using System;
using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment.Extensions;

namespace Facebook.Drivers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class ActivityFeedDriver : ContentPartDriver<ActivityFeedPart> {
        protected override string Prefix {
            get {
                return "activityfeed";
            }
        }

        protected override DriverResult Display(ActivityFeedPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_ActivityFeed",
                                () => shapeHelper.Parts_ActivityFeed(Site: part.Site,
                                                                Width: part.Width,
                                                                Height: part.Height,
                                                                MaxAge: part.MaxAge,
                                                                ColorScheme: part.ColorScheme,
                                                                ShowHeader: part.ShowHeader,
                                                                ShowRecommendations: part.ShowRecommendations,
                                                                Actions: part.Actions,
                                                                AppId: part.AppId,
                                                                Filter: part.Filter,
                                                                Ref: part.Ref));
        }

        //GET
        protected override DriverResult Editor(ActivityFeedPart part, dynamic shapeHelper) {
            return ContentShape("Parts_ActivityFeed_Edit",
                                () => shapeHelper.EditorTemplate(
                                    TemplateName: "Parts/Facebook/ActivityFeed",
                                    Model: part,
                                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(ActivityFeedPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override void Exporting(ActivityFeedPart part, ExportContentContext context) {
            context.Element(part.PartDefinition.Name).SetAttributeValue("Site", part.Record.Site);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Width", part.Record.Width);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Height", part.Record.Width);
            context.Element(part.PartDefinition.Name).SetAttributeValue("MaxAge", part.Record.MaxAge);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ColorScheme", part.Record.ColorScheme);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ShowHeader", part.Record.ShowHeader);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ShowRecommendations", part.Record.ShowRecommendations);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Actions", part.Record.Actions);
            context.Element(part.PartDefinition.Name).SetAttributeValue("AppId", part.Record.AppId);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Filter", part.Record.Filter);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Ref", part.Record.Ref);
        }

        protected override void Importing(ActivityFeedPart part, ImportContentContext context) {
            part.Record.Site = context.Attribute(part.PartDefinition.Name, "Site");
            part.Record.Width = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "Width"));
            part.Record.Height = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "Height"));
            part.Record.MaxAge = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "MaxAge"));
            part.Record.ColorScheme = context.Attribute(part.PartDefinition.Name, "ColorScheme");
            part.Record.ShowHeader = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ShowHeader"));
            part.Record.ShowRecommendations = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ShowRecommendations"));
            part.Record.Actions = context.Attribute(part.PartDefinition.Name, "Actions");
            part.Record.AppId = context.Attribute(part.PartDefinition.Name, "AppId");
            part.Record.Filter = context.Attribute(part.PartDefinition.Name, "Filter");
            part.Record.Ref = context.Attribute(part.PartDefinition.Name, "Ref");
        }
    }
}