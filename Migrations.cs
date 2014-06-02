using System.Data;
using Facebook.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;

namespace Facebook {
    [OrchardFeature("Facebook")]
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("FacebookSettingsPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("AppId")
                .Column<string>("AppSecret")
               );

            return 1;
        }
    }
}