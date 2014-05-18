using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Facebook.Models.Enums;

namespace Facebook.Drivers
{
    public class RecommendationDriver : ContentPartDriver<RecommendationPart>
    {
        protected override DriverResult Display(RecommendationPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_Recommendation",
                                () => shapeHelper.Parts_Recommendation(Site: part.Site,
                                                                Width: part.Width,
                                                                Height: part.Height,
                                                                ColorScheme: part.ColorScheme,
                                                                ShowHeader: part.ShowHeader,
                                                                Font: part.Font,
                                                                BorderColor: part.BorderColor,
                                                                Filter: part.Filter,
                                                                RefLabel: part.RefLabel,
                                                                Language: part.Language));
        }

        //GET
        protected override DriverResult Editor(RecommendationPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_Recommendation_Edit",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts/Facebook/Recommendation", Model: part));
        }

        //POST
        protected override DriverResult Editor(RecommendationPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}