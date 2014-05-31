using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class RecommendationFeedPartRecord : ContentPartRecord {
        public RecommendationFeedPartRecord() {
            Width = 300;
            Height = 300;
            MaxAge = 0;
            ColorScheme = "Light";
            ShowHeader = true;
        }

        [RegularExpression(@"^(?:(?:[a-z0-9!#$%&'*+\-/=?^_`{|}~]+\.)+[a-z]+|(?:\d{1,3}\.){3}\d{1,3})$")]
        public virtual string Site { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int MaxAge { get; set; }
        public virtual string ColorScheme { get; set; }
        public virtual bool ShowHeader { get; set; }
        public virtual string Actions { get; set; }
        public virtual string AppId { get; set; }
        public virtual string Ref { get; set; }
    }
}