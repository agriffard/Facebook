using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Facebook.Models.Enums;

namespace Facebook.Drivers
{
    public class LikeBoxDriver : ContentPartDriver<LikeBoxPart>
    {
        protected override DriverResult Display(LikeBoxPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_LikeBox",
                                () => shapeHelper.Parts_LikeBox(Href: part.Href,
                                                                Width: part.Width,
                                                                Height: part.Height,
                                                                ColorScheme: part.ColorScheme,
                                                                Connections: part.Connections,
                                                                ShowStream: part.ShowStream,
                                                                ShowHeader: part.ShowHeader,
                                                                Language: part.Language));
        }

        //GET
        protected override DriverResult Editor(LikeBoxPart part, dynamic shapeHelper)
        {
            if (part.ContentItem.Id != 0)
            {
                // Default insert values
                part.Width = 292;
                part.Height = 587;
                part.ColorScheme = ColorScheme.Light;
                part.Connections = 10;
                part.ShowHeader = true;
                part.ShowStream = true;
            }

            return ContentShape("Parts_LikeBox_Edit",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts/Facebook/LikeBox", Model: part));
        }

        //POST
        protected override DriverResult Editor(LikeBoxPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}