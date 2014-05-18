using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Facebook.Models.Enums;

namespace Facebook.Drivers
{
    public class FacepileDriver : ContentPartDriver<FacepilePart>
    {
        protected override DriverResult Display(FacepilePart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_Facepile",
                                () => shapeHelper.Parts_Facepile(Url: part.Url,
                                                                Width: part.Width,
                                                                NumRows: part.NumRows,
                                                                Language: part.Language));
        }

        //GET
        protected override DriverResult Editor(FacepilePart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_Facepile_Edit",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts/Facebook/Facepile", Model: part));
        }

        //POST
        protected override DriverResult Editor(FacepilePart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}