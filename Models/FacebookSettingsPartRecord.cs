using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;

namespace Facebook.Models
{
    public class FacebookSettingsPartRecord : ContentPartRecord {
        public virtual string AppId { get; set; }
        public virtual string AppSecret { get; set; }
        public virtual string Language { get; set; }
    }
}