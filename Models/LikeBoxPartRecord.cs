using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Facebook.Models {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class LikeBoxPartRecord : ContentPartRecord {
        public LikeBoxPartRecord() {
            Width = 292;
            Height = 556;
            ColorScheme = "Light";
            ShowStream = true;
            ShowHeader = true;
            ShowBorder = true;
            ShowFaces = true;
            ForceWall = false;
        }

        [RegularExpression(@"^(?:(?:[a-z0-9!#$%&'*+\-/=?^_`{|}~]+\.)+[a-z]+|(?:\d{1,3}\.){3}\d{1,3})$")]
        public virtual string Href { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual string ColorScheme { get; set; }
        public virtual bool ShowStream { get; set; }
        public virtual bool ShowHeader { get; set; }
        public virtual bool ShowBorder { get; set; }
        public virtual bool ShowFaces { get; set; }
        public virtual bool ForceWall { get; set; }
    }
}