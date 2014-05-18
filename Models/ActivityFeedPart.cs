using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Facebook.Extensions;
using Facebook.Models.Enums;

namespace Facebook.Models
{
    public class ActivityFeedPart : ContentPart<ActivityFeedPartRecord>
    {
        [Required]
        public string Site
        {
            get { return Record.Site; }
            set { Record.Site = value; }
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

        public bool ShowHeader
        {
            get { return Record.ShowHeader; }
            set { Record.ShowHeader = value; }
        }

        public bool ShowRecommendations
        {
            get { return Record.ShowRecommendations; }
            set { Record.ShowRecommendations = value; }
        }

        public string Font
        {
            get { return Record.Font; }
            set { Record.Font = value; }
        }

        public string BorderColor
        {
            get { return Record.BorderColor; }
            set { Record.BorderColor = value; }
        }

        public string Language
        {
            get { return Record.Language; }
            set { Record.Language = value; }
        }
    }
}
