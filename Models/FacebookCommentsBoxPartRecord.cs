using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.CommentsBox")]
    public class FacebookCommentsBoxPartRecord : ContentPartRecord {
        public FacebookCommentsBoxPartRecord() {
            CommentsShown = true;
        }

        public virtual bool CommentsShown { get; set; }
    }
}