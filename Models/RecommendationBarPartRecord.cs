using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class RecommendationBarPartRecord : ContentPartRecord {
        public RecommendationBarPartRecord() {
            MaxAge = 0;
            ReadTime = 30;
            NumRecommendations = 2;
            Actions = "Like";
            Side = "left";
            ExpandTrigger = "onvisible";
        }

        [RegularExpression(@"^(?:(?:[a-z0-9!#$%&'*+\-/=?^_`{|}~]+\.)+[a-z]+|(?:\d{1,3}\.){3}\d{1,3})$")]
        public virtual string Href { get; set; }
        public virtual string Site { get; set; }
        public virtual int MaxAge { get; set; }
        public virtual int ReadTime { get; set; }
        public virtual int NumRecommendations { get; set; }
        public virtual string Side { get; set; }
        public virtual string Actions { get; set; }
        public virtual string ExpandTrigger { get; set; }
        public virtual string Ref { get; set; }
    }
}