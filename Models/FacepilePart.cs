using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class FacepilePart : ContentPart<FacepilePartRecord> {
        [Required]
        public string Href {
            get { return Retrieve(r => r.Href); }
            set { Store(r => r.Href, value); }
        }

        public int Width {
            get { return Retrieve(r => r.Width, 300); }
            set { Store(r => r.Width, value); }
        }

        public int NumRows {
            get { return Retrieve(r => r.NumRows, 1); }
            set { Store(r => r.NumRows, value); }
        }

        public string Actions {
            get { return Retrieve(r => r.Actions, "like"); }
            set { Store(r => r.Actions, value); }
        }

        public string Size {
            get { return Retrieve(r => r.Size, "Medium"); }
            set { Store(r => r.Size, value); }
        }

        public string ColorScheme {
            get { return Retrieve(r => r.ColorScheme, "Light"); }
            set { Store(r => r.ColorScheme, value); }
        }

        public string AppId {
            get { return Retrieve(r => r.AppId); ; }
            set { Store(r => r.AppId, value); }
        }
    }
}
