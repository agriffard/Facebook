using System.ComponentModel.DataAnnotations;
using Orchard.Environment.Extensions;
using Orchard.ContentManagement;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class FacebookLikeButtonPart : ContentPart<FacebookLikeButtonPartRecord> {
        [Required]
        public int Width {
            get { return Retrieve(x => x.Width, 500); }
            set { Store(x => x.Width, value); }
        }

        [Required]
        public string ColorScheme {
            get { return Retrieve(x => x.ColorScheme, "light"); }
            set { Store(x => x.ColorScheme, value); }
        }
        
        [Required]
        public string Layout {
            get { return Retrieve(x => x.Layout, "standard"); }
            set { Store(x => x.Layout, value); }
        }

        [Required]
        public bool Share {
            get { return Retrieve(x => x.Share, false); }
            set { Store(x => x.Share, value); }
        }

        [Required]
        public bool ShowFaces {
            get { return Retrieve(x => x.ShowFaces, false); }
            set { Store(x => x.ShowFaces, value); }
        }

        [Required]
        public string Action {
            get { return Retrieve(x => x.Action, "like"); }
            set { Store(x => x.Action, value); }
        }

        public string Ref {
            get { return Retrieve(x => x.Ref); }
            set { Store(x => x.Ref, value); }
        }
    }
}