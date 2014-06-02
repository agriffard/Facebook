using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook")]
    public class FacebookSettingsPart : ContentPart {
        [Required]
        public string AppId {
            get { return this.Retrieve(x => x.AppId); }
            set { this.Store(x => x.AppId, value); }
        }

        [Required]
        public string AppSecret {
            get { return this.Retrieve(x => x.AppSecret); }
            set { this.Store(x => x.AppSecret, value); }
        }
    }
}
