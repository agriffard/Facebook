using System.ComponentModel.DataAnnotations;
using Facebook.Extensions;
using Facebook.Models.Enums;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class RecommendationFeedPart : ContentPart<RecommendationFeedPartRecord> {
        [Required]
        public string Site {
            get { return Retrieve(r => r.Site); }
            set { Store(r => r.Site, value); }
        }

        public int Width {
            get { return Retrieve(r => r.Width, 300); }
            set { Store(r => r.Width, value); }
        }

        public int Height {
            get { return Retrieve(r => r.Height, 300); }
            set { Store(r => r.Height, value); }
        }

        public int MaxAge {
            get { return Retrieve(r => r.MaxAge, 0); }
            set { Store(r => r.MaxAge, value); }
        }

        public string ColorScheme {
            get { return Retrieve(r => r.ColorScheme); }
            set { Store(r => r.ColorScheme, value); }
        }

        public bool ShowHeader {
            get { return Retrieve(r => r.ShowHeader, true); }
            set { Store(r => r.ShowHeader, value); }
        }
        
        public string Actions {
            get { return Retrieve(r => r.Actions, "like"); }
            set { Store(r => r.Actions, value); }
        }

        public string AppId {
            get { return Retrieve(r => r.AppId); }
            set { Store(r => r.AppId, value); }
        }

        public string Ref {
            get { return Retrieve(r => r.Ref); }
            set { Store(r => r.Ref, value); }
        }
    }
}
