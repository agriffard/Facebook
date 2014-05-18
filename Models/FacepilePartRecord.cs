using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;

namespace Facebook.Models
{
    public class FacepilePartRecord : ContentPartRecord {
        [RegularExpression(@"^(?:(?:[a-z0-9!#$%&'*+\-/=?^_`{|}~]+\.)+[a-z]+|(?:\d{1,3}\.){3}\d{1,3})$")]
        public virtual string Url { get; set; }
        public virtual int Width { get; set; }
        public virtual int NumRows { get; set; }
        public virtual string Language { get; set; }

        public FacepilePartRecord()
        {
            Width = 200;
            NumRows = 1;
            Language = "en_US";
        }
    }
}