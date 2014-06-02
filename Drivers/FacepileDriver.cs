using System;
using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment.Extensions;

namespace Facebook.Drivers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class FacepileDriver : ContentPartDriver<FacepilePart> {
        protected override string Prefix {
            get {
                return "facepile";
            }
        }

        protected override DriverResult Display(FacepilePart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_Facepile",
                                () => shapeHelper.Parts_Facepile(Href: part.Href,
                                                                Width: part.Width,
                                                                NumRows: part.NumRows,
                                                                Actions: part.Actions,
                                                                ColorScheme: part.ColorScheme,
                                                                Size: part.Size,
                                                                AppId: part.AppId));
        }

        //GET
        protected override DriverResult Editor(FacepilePart part, dynamic shapeHelper) {
            return ContentShape("Parts_Facepile_Edit",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts/Facebook/Facepile",
                                    Model: part,
                                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(FacepilePart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override void Exporting(FacepilePart part, ExportContentContext context) {
            context.Element(part.PartDefinition.Name).SetAttributeValue("Href", part.Record.Href);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Width", part.Record.Width);
            context.Element(part.PartDefinition.Name).SetAttributeValue("NumRows", part.Record.NumRows);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Actions", part.Record.Actions);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Size", part.Record.Size);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ColorScheme", part.Record.ColorScheme);
            context.Element(part.PartDefinition.Name).SetAttributeValue("AppId", part.Record.AppId);
        }

        protected override void Importing(FacepilePart part, ImportContentContext context) {
            part.Record.Href = context.Attribute(part.PartDefinition.Name, "Href");
            part.Record.Width = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "Width"));
            part.Record.NumRows = Convert.ToInt32(context.Attribute(part.PartDefinition.Name, "NumRows"));
            part.Record.Actions = context.Attribute(part.PartDefinition.Name, "Actions");
            part.Record.Size = context.Attribute(part.PartDefinition.Name, "Size");
            part.Record.ColorScheme = context.Attribute(part.PartDefinition.Name, "ColorScheme");
            part.Record.AppId = context.Attribute(part.PartDefinition.Name, "AppId");
        }
    }
}