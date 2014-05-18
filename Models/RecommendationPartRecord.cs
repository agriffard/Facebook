using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;
using Facebook.Models.Enums;

namespace Facebook.Models
{
    public class RecommendationPartRecord : ContentPartRecord
    {
        [RegularExpression(@"^(?:(?:[a-z0-9!#$%&'*+\-/=?^_`{|}~]+\.)+[a-z]+|(?:\d{1,3}\.){3}\d{1,3})$")]
        public virtual string Site { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual byte ColorScheme { get; set; }
        public virtual bool ShowHeader { get; set; }
        public virtual string Font { get; set; }
        public virtual string BorderColor { get; set; }
        public virtual string Filter { get; set; }
        public virtual string RefLabel { get; set; }
        public virtual string Language { get; set; }

        public RecommendationPartRecord()
        {
            Width = 300;
            Height = 300;
            ColorScheme = (byte)Facebook.Models.Enums.ColorScheme.Light;
            ShowHeader = true;
            // Font = "Lucida Grande";
            Language = "en_US";
        }
    }
}