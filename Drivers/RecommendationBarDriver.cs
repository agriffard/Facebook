using System;
using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment.Extensions;

namespace Facebook.Drivers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class RecommendationBarDriver : ContentPartDriver<RecommendationBarPart> {
        protected override string Prefix {
            get {
                return "recommendationbar";
            }
        }

        protected override DriverResult Display(RecommendationBarPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_RecommendationBar",
                                () => shapeHelper.Parts_RecommendationBar(Href: part.Href,
                                                                Site: part.Site,
                                                                MaxAge: part.MaxAge,
                                                                ReadTime: part.ReadTime,
                                                                NumRecommendations: part.NumRecommendations,
                                                                Side: part.Side,
                                                                Actions: part.Actions,
                                                                ExpandTrigger: part.ExpandTrigger,
                                                                Ref: part.Ref));
        }

        //GET
        protected override DriverResult Editor(RecommendationBarPart part, dynamic shapeHelper) {
            return ContentShape("Parts_RecommendationBar_Edit",
                                () => shapeHelper.EditorTemplate(
                                    TemplateName: "Parts/Facebook/RecommendationBar",
                                    Model: part,
                                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(RecommendationBarPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override void Exporting(RecommendationBarPart part, ExportContentContext context) {
            context.Element(part.PartDefinition.Name).SetAttributeValue("Href", part.Record.Href);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Site", part.Record.Site);
            context.Element(part.PartDefinition.Name).SetAttributeValue("MaxAge", part.Record.MaxAge);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ReadTime", part.Record.ReadTime);
            context.Element(part.PartDefinition.Name).SetAttributeValue("NumRecommendations", part.Record.NumRecommendations);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Side", part.Record.Side);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Actions", part.Record.Actions);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ExpandTrigger", part.Record.ExpandTrigger);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Ref", part.Record.Ref);
        }

        protected override void Importing(RecommendationBarPart part, ImportContentContext context) {
            part.Record.Href = context.Attribute(part.PartDefinition.Name, "Href");
            part.Record.Site = context.Attribute(part.PartDefinition.Name, "Site");
            part.Record.MaxAge = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "MaxAge"));
            part.Record.ReadTime = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "ReadTime"));
            part.Record.NumRecommendations = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "NumRecommendations"));
            part.Record.Side = context.Attribute(part.PartDefinition.Name, "Side");
            part.Record.Actions = context.Attribute(part.PartDefinition.Name, "Actions");
            part.Record.ExpandTrigger = context.Attribute(part.PartDefinition.Name, "ExpandTrigger");
            part.Record.Ref = context.Attribute(part.PartDefinition.Name, "Ref");
        }
    }
}