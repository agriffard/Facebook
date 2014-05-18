using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;

namespace Facebook.Models
{
    public class LikeBoxPartRecord : ContentPartRecord {
        [RegularExpression(@"^(?:(?:[a-z0-9!#$%&'*+\-/=?^_`{|}~]+\.)+[a-z]+|(?:\d{1,3}\.){3}\d{1,3})$")]
        public virtual string Href { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual byte ColorScheme { get; set; }
        public virtual int Connections { get; set; }
        public virtual bool ShowStream { get; set; }
        public virtual bool ShowHeader { get; set; }
        public virtual string Language { get; set; }

        public LikeBoxPartRecord()
        {
            Width = 292;
            Height = 587;
            ColorScheme = (byte)Facebook.Models.Enums.ColorScheme.Light;
            Connections = 10;
            ShowHeader = true;
            ShowStream  = true;
            Language = "en_US";
        }
    }
}