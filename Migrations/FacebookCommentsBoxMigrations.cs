using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;
using Facebook.Models;

namespace Facebook {
    [OrchardFeature("Facebook.CommentsBox")]
    public class FacebookCommentsBoxMigrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable(typeof(FacebookCommentsBoxPartRecord).Name,
                    table => table
                    .ContentPartRecord()
                    .Column<bool>("CommentsShown")
                );

            ContentDefinitionManager.AlterPartDefinition(typeof(FacebookCommentsBoxPart).Name,
                builder => builder.Attachable()
                .WithDescription("Allows content items to be commented on Facebook."));

            ContentDefinitionManager.AlterPartDefinition("CommentsContainerPart", part => part
                .WithDescription("Adds support to a content type to contain Facebook comments."));

            return 1;
        }
    }
}