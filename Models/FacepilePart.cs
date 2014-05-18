using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;

namespace Facebook.Models
{
    public class FacepilePart : ContentPart<FacepilePartRecord>
    {
        [Required]
        public string Url
        {
            get { return Record.Url; }
            set { Record.Url = value; }
        }

        public int Width
        {
            get { return Record.Width; }
            set { Record.Width = value; }
        }

        public int NumRows
        {
            get { return Record.NumRows; }
            set { Record.NumRows = value; }
        }

        public string Language
        {
            get { return Record.Language; }
            set { Record.Language = value; }
        }
    }
}
