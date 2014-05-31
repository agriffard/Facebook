using System.ComponentModel.DataAnnotations;
using Facebook.Extensions;
using Facebook.Models.Enums;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class RecommendationBarPart : ContentPart<RecommendationBarPartRecord> {
        [Required]
        public string Href {
            get { return Retrieve(r => r.Href); }
            set { Store(r => r.Href, value); }
        }

        public string Site {
            get { return Retrieve(r => r.Site); }
            set { Store(r => r.Site, value); }
        }

        public int MaxAge {
            get { return Retrieve(r => r.MaxAge, 0); }
            set { Store(r => r.MaxAge, value); }
        }

        public int ReadTime {
            get { return Retrieve(r => r.ReadTime, 30); }
            set { Store(r => r.ReadTime, value); }
        }

        public int NumRecommendations {
            get { return Retrieve(r => r.NumRecommendations, 2); }
            set { Store(r => r.NumRecommendations, value); }
        }
        
        public string Side {
            get { return Retrieve(r => r.Side, "left"); }
            set { Store(r => r.Side, value); }
        }

        public string Actions {
            get { return Retrieve(r => r.Actions, "like"); }
            set { Store(r => r.Actions, value); }
        }

        public string ExpandTrigger {
            get { return Retrieve(r => r.ExpandTrigger, "onvisible"); }
            set { Store(r => r.ExpandTrigger, value); }
        }

        public string Ref {
            get { return Retrieve(r => r.Ref); }
            set { Store(r => r.Ref, value); }
        }
    }
}
