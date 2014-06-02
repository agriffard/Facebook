using System;
using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment.Extensions;

namespace Facebook.Drivers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class FacebookLikeButtonPartDriver : ContentPartDriver<FacebookLikeButtonPart> {
        protected override string Prefix {
            get { return "LikeButton"; }
        }

        protected override DriverResult Display(FacebookLikeButtonPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_FacebookLikeButton",
                    () => shapeHelper.Parts_FacebookLikeButton(Width: part.Width,
                                                                ColorScheme: part.ColorScheme,
                                                                Share: part.Share,
                                                                ShowFaces: part.ShowFaces,
                                                                Action: part.Action,
                                                                Ref: part.Ref));
        }

        // GET
        protected override DriverResult Editor(FacebookLikeButtonPart part, dynamic shapeHelper) {
            return ContentShape("Parts_FacebookLikeButton_Edit",
                    () => shapeHelper.EditorTemplate(
                        TemplateName: "Parts/Facebook/FacebookLikeButton",
                        Model: part,
                        Prefix: Prefix));
        }

        // POST
        protected override DriverResult Editor(FacebookLikeButtonPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override void Exporting(FacebookLikeButtonPart part, ExportContentContext context) {
            context.Element(part.PartDefinition.Name).SetAttributeValue("Width", part.Record.Width);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ColorScheme", part.Record.ColorScheme);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Share", part.Record.Share);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ShowFaces", part.Record.ShowFaces);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Action", part.Record.Action);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Ref", part.Record.Ref);
        }

        protected override void Importing(FacebookLikeButtonPart part, ImportContentContext context) {
            part.Record.Width = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "Width"));
            part.Record.ColorScheme = context.Attribute(part.PartDefinition.Name, "ColorScheme");
            part.Record.Share = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "Share"));
            part.Record.ShowFaces = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ShowFaces"));
            part.Record.Action = context.Attribute(part.PartDefinition.Name, "Action");
            part.Record.Ref = context.Attribute(part.PartDefinition.Name, "Ref");
        }
    }
}