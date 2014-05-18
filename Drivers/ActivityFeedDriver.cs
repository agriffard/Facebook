using Facebook.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Facebook.Models.Enums;

namespace Facebook.Drivers
{
    public class ActivityFeedDriver : ContentPartDriver<ActivityFeedPart>
    {
        protected override DriverResult Display(ActivityFeedPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_ActivityFeed",
                                () => shapeHelper.Parts_ActivityFeed(Site: part.Site,
                                                                Width: part.Width,
                                                                Height: part.Height,
                                                                ColorScheme: part.ColorScheme,
                                                                ShowHeader: part.ShowHeader,
                                                                ShowRecommendations: part.ShowRecommendations,
                                                                Font: part.Font,
                                                                BorderColor: part.BorderColor,
                                                                Language: part.Language));
        }

        //GET
        protected override DriverResult Editor(ActivityFeedPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_ActivityFeed_Edit",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts/Facebook/ActivityFeed", Model: part));
        }

        //POST
        protected override DriverResult Editor(ActivityFeedPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}