using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class FacepilePartRecord : ContentPartRecord {
        public FacepilePartRecord() {
            Width = 300;
            NumRows = 1;
            Actions = "like";
            ColorScheme = "Light";
            AppId = "";
        }

        [RegularExpression(@"^(?:(?:[a-z0-9!#$%&'*+\-/=?^_`{|}~]+\.)+[a-z]+|(?:\d{1,3}\.){3}\d{1,3})$")]
        public virtual string Href { get; set; }
        public virtual int Width { get; set; }
        public virtual int NumRows { get; set; }
        public virtual string Actions { get; set; }
        public virtual string Size { get; set; }
        public virtual string ColorScheme { get; set; }
        public virtual string AppId { get; set; }
    }
}