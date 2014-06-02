using Orchard.Environment.Extensions;
using Orchard.ContentManagement.Records;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class FacebookLikeButtonPartRecord : ContentPartRecord {
        public virtual int Width { get; set; }
        public virtual string ColorScheme { get; set; }
        public virtual string Layout { get; set; }
        public virtual bool Share { get; set; }
        public virtual bool ShowFaces { get; set; }
        public virtual string Action { get; set; }
        public virtual string Ref { get; set; }

        public FacebookLikeButtonPartRecord() {
            Width = 500;
            ColorScheme = "light";
            Layout = "standard";
            Share = false;
            ShowFaces = false;
            Action = "like";
        }
    }
}