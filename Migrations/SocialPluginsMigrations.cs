using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;
using Facebook.Models;

namespace Facebook {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class SocialPluginsMigrations : DataMigrationImpl {

        public int Create() {
            SchemaBuilder.CreateTable(
                "LikeBoxPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Href")
                .Column<int>("Width")
                .Column<int>("Height")
                .Column<string>("ColorScheme")
                .Column<bool>("ShowStream")
                .Column<bool>("ShowHeader")
                .Column<bool>("ShowBorder")
                .Column<bool>("ShowFaces")
                .Column<bool>("ForceWall")
            );

            ContentDefinitionManager.AlterPartDefinition(
                typeof(LikeBoxPart).Name, cfg => cfg
                    .Attachable()
                    .WithDescription("Adds a Facebook Like Box to the content item."));

            ContentDefinitionManager.AlterTypeDefinition(
                "LikeBoxWidget", cfg => cfg
                .WithPart("LikeBoxPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            return 1;
        }

        public int UpdateFrom1() {
            SchemaBuilder.CreateTable("FacepilePartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Href")
                .Column<int>("Width")
                .Column<int>("NumRows")
                .Column<string>("Actions")
                .Column<string>("ColorScheme")
                .Column<string>("Size")
                .Column<string>("AppId")
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(FacepilePart).Name, cfg => cfg
                .Attachable()
                .WithDescription("Adds a Facepile to the content item."));

            ContentDefinitionManager.AlterTypeDefinition("FacepileWidget", cfg => cfg
                .WithPart("FacepilePart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            return 2;
        }

        public int UpdateFrom2() {
            SchemaBuilder.CreateTable("ActivityFeedPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Site")
                .Column<int>("Width")
                .Column<int>("Height")
                .Column<int>("MaxAge")
                .Column<string>("ColorScheme")
                .Column<bool>("ShowHeader")
                .Column<bool>("ShowRecommendations")
                .Column<string>("Actions")
                .Column<string>("AppId")
                .Column<string>("Filter")
                .Column<string>("Ref")
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(ActivityFeedPart).Name, cfg => cfg
                .Attachable()
                .WithDescription("Adds a Facebook Activity Feed to the content item."));

            ContentDefinitionManager.AlterTypeDefinition("ActivityFeedWidget", cfg => cfg
                .WithPart("ActivityFeedPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            return 3;
        }

        public int UpdateFrom3() {
            SchemaBuilder.CreateTable("RecommendationFeedPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Site")
                .Column<int>("Width")
                .Column<int>("Height")
                .Column<int>("MaxAge")
                .Column<string>("ColorScheme")
                .Column<bool>("ShowHeader")
                .Column<string>("Actions")
                .Column<string>("AppId")
                .Column<string>("Ref")
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(RecommendationFeedPart).Name, cfg => cfg
                .Attachable()
                .WithDescription("Adds a Facebook Recommendation Feed to the content item."));

            ContentDefinitionManager.AlterTypeDefinition("RecommendationFeedWidget", cfg => cfg
                .WithPart("RecommendationFeedPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            return 4;
        }

        public int UpdateFrom4() {
            SchemaBuilder.CreateTable("RecommendationBarPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Href")
                .Column<string>("Site")
                .Column<int>("MaxAge")
                .Column<int>("ReadTime")
                .Column<int>("NumRecommendations")
                .Column<string>("Side")
                .Column<string>("Actions")
                .Column<string>("ExpandTrigger")
                .Column<string>("Ref")
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(RecommendationBarPart).Name, cfg => cfg
                .Attachable()
                .WithDescription("Adds a Facebook Recommendation Bar to the content item."));

            ContentDefinitionManager.AlterTypeDefinition("RecommendationBarWidget", cfg => cfg
                .WithPart("RecommendationBarPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            return 5;
        }

        public int UpdateFrom5() {
            SchemaBuilder.CreateTable(typeof(FacebookLikeButtonPartRecord).Name,
                table => table
                    .ContentPartRecord()
                    .Column<int>("Width")
                    .Column<string>("ColorScheme")
                    .Column<string>("Layout")
                    .Column<bool>("Share")
                    .Column<bool>("ShowFaces")
                    .Column<string>("Action")
                    .Column<string>("Ref")
                );

            ContentDefinitionManager.AlterPartDefinition(typeof(FacebookLikeButtonPartRecord).Name, cfg => cfg
                .Attachable()
                .WithDescription("Adds a Facebook Button to the content item."));

            ContentDefinitionManager.AlterTypeDefinition("FacebookLikeButtonWidget",
                cfg => cfg
                    .WithPart(typeof(FacebookLikeButtonPart).Name)
                    .WithPart("WidgetPart")
                    .WithPart("CommonPart")
                    .WithSetting("Stereotype", "Widget")
                );

            return 6;
        }
    }
}