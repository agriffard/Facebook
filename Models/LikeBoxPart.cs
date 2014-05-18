using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Facebook.Extensions;
using Facebook.Models.Enums;

namespace Facebook.Models
{
    public class LikeBoxPart : ContentPart<LikeBoxPartRecord>
    {
        [Required]
        public string Href
        {
            get { return Record.Href; }
            set { Record.Href = value; }
        }

        public int Width
        {
            get { return Record.Width; }
            set { Record.Width = value; }
        }

        public int Height
        {
            get { return Record.Height; }
            set { Record.Height = value; }
        }

        public ColorScheme ColorScheme
        {
            get { return Record.ColorScheme.ToColorScheme(); }
            set { Record.ColorScheme = (byte)value; }
        }

        public int Connections
        {
            get { return Record.Connections; }
            set { Record.Connections = value; }
        }

        public bool ShowStream
        {
            get { return Record.ShowStream; }
            set { Record.ShowStream = value; }
        }

        public bool ShowHeader
        {
            get { return Record.ShowHeader; }
            set { Record.ShowHeader = value; }
        }

        public string Language
        {
            get { return Record.Language; }
            set { Record.Language = value; }
        }
    }
}
