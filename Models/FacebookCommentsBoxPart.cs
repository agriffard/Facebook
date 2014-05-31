using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.CommentsBox")]
    public class FacebookCommentsBoxPart : ContentPart<FacebookCommentsBoxPartRecord> {
        public bool CommentsShown {
            get { return Retrieve(x => Record.CommentsShown, true); }
            set { Store(x => Record.CommentsShown, value); }
        }
    }
}