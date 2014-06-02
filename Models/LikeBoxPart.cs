using Orchard.ContentManagement;
using Orchard.Environment.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class LikeBoxPart : ContentPart<LikeBoxPartRecord> {
        [Required]
        public string Href {
            get { return Retrieve(r => r.Href); }
            set { Store(r => r.Href, value); }
        }

        public int Width {
            get { return Retrieve(r => r.Width, 292); }
            set { Store(r => r.Width, value); }
        }

        public int Height {
            get { return Retrieve(r => r.Height, 556); }
            set { Store(r => r.Height, value); }
        }

        public string ColorScheme {
            get { return Retrieve(r => r.ColorScheme, "Light"); }
            set { Store(r => r.ColorScheme, value); }
        }

        public bool ShowStream {
            get { return Retrieve(r => r.ShowStream, true); }
            set { Store(r => r.ShowStream, value); }
        }

        public bool ShowHeader {
            get { return Retrieve(r => r.ShowHeader, true); }
            set { Store(r => r.ShowHeader, value); }
        }

        public bool ShowBorder {
            get { return Retrieve(r => r.ShowBorder, true); }
            set { Store(r => r.ShowBorder, value); }
        }

        public bool ShowFaces {
            get { return Retrieve(r => r.ShowFaces, true); }
            set { Store(r => r.ShowFaces, value); }
        }

        public bool ForceWall {
            get { return Retrieve(r => r.ForceWall, false); }
            set { Store(r => r.ForceWall, value); }
        }
    }
}
