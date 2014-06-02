using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook")]
    public class FacebookSettingsPartRecord : ContentPartRecord {
        public virtual string AppId { get; set; }
        public virtual string AppSecret { get; set; }
    }
}