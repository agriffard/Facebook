using System;
using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment.Extensions;

namespace Facebook.Drivers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class LikeBoxDriver : ContentPartDriver<LikeBoxPart> {
        protected override string Prefix {
            get {
                return "likebox";
            }
        }

        protected override DriverResult Display(LikeBoxPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_LikeBox", () => shapeHelper.Parts_LikeBox(Href: part.Href,
                                                                Width: part.Width,
                                                                Height: part.Height,
                                                                ColorScheme: part.ColorScheme,
                                                                ShowStream: part.ShowStream,
                                                                ShowHeader: part.ShowHeader,
                                                                ShowBorder: part.ShowBorder,
                                                                ShowFaces: part.ShowBorder,
                                                                ForceWall: part.ForceWall));
        }

        //GET
        protected override DriverResult Editor(LikeBoxPart part, dynamic shapeHelper) {
            return ContentShape("Parts_LikeBox_Edit",
                                () => shapeHelper.EditorTemplate(
                                    TemplateName: "Parts/Facebook/LikeBox",
                                    Model: part,
                                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(LikeBoxPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);

            return Editor(part, shapeHelper);
        }

        protected override void Exporting(LikeBoxPart part, ExportContentContext context) {
            context.Element(part.PartDefinition.Name).SetAttributeValue("Href", part.Record.Href);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Width", part.Record.Width);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Height", part.Record.Height);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ColorScheme", part.Record.ColorScheme);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ShowStream", part.Record.ShowStream);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ShowHeader", part.Record.ShowHeader);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ShowBorder", part.Record.ShowBorder);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ShowFaces", part.Record.ShowFaces);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ForceWall", part.Record.ForceWall);
        }

        protected override void Importing(LikeBoxPart part, ImportContentContext context) {
            part.Record.Href = context.Attribute(part.PartDefinition.Name, "Href");
            part.Record.Width = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "Width"));
            part.Record.Height = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "Height"));
            part.Record.ColorScheme = context.Attribute(part.PartDefinition.Name, "ColorScheme");
            part.Record.ShowStream = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ShowStream"));
            part.Record.ShowHeader = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ShowHeader"));
            part.Record.ShowBorder = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ShowBorder"));
            part.Record.ShowFaces = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ShowFaces"));
            part.Record.ForceWall = Convert.ToBoolean(context.Attribute(part.PartDefinition.Name, "ForceWall"));
        }
    }
}