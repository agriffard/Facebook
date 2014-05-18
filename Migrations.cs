using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Facebook.Models;

namespace Facebook
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable("FacebookSettingsPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("AppId")
                .Column<string>("Secret")
               );

            SchemaBuilder.CreateTable("LikeBoxPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Href")
                .Column<int>("Width")
                .Column<int>("Height")
                .Column<byte>("ColorScheme")
                .Column<int>("Connections")
                .Column<bool>("ShowStream")
                .Column<bool>("ShowHeader")
                .Column<string>("Language")
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(LikeBoxPart).Name, cfg => cfg
                .Attachable());

            ContentDefinitionManager.AlterTypeDefinition("LikeBoxWidget", cfg => cfg
                .WithPart("LikeBoxPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            return 1;
        }

        public int UpdateFrom1()
        {
            SchemaBuilder.CreateTable("FacepilePartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Url")
                .Column<int>("Width")
                .Column<int>("NumRows")
                .Column<string>("Language")
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(FacepilePart).Name, cfg => cfg
                .Attachable());

            ContentDefinitionManager.AlterTypeDefinition("FacepileWidget", cfg => cfg
                .WithPart("FacepilePart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            SchemaBuilder.CreateTable("ActivityFeedPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Site")
                .Column<int>("Width")
                .Column<int>("Height")
                .Column<byte>("ColorScheme")
                .Column<bool>("ShowHeader")
                .Column<bool>("ShowRecommendations")
                .Column<string>("Font")
                .Column<string>("BorderColor")
                .Column<string>("Language")
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(ActivityFeedPart).Name, cfg => cfg
                .Attachable());

            ContentDefinitionManager.AlterTypeDefinition("ActivityFeedWidget", cfg => cfg
                .WithPart("ActivityFeedPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            SchemaBuilder.CreateTable("RecommendationPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("Site")
                .Column<int>("Width")
                .Column<int>("Height")
                .Column<byte>("ColorScheme")
                .Column<bool>("ShowHeader")
                .Column<string>("Font")
                .Column<string>("BorderColor")
                .Column<string>("Filter")
                .Column<string>("RefLabel")
                .Column<string>("Language")
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(RecommendationPart).Name, cfg => cfg
                .Attachable());

            ContentDefinitionManager.AlterTypeDefinition("RecommendationWidget", cfg => cfg
                .WithPart("RecommendationPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            return 2;
        }
    }
}