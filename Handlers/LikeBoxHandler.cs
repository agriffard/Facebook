using Facebook.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;

namespace Facebook.Handlers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class LikeBoxPartHandler : ContentHandler {
        public LikeBoxPartHandler(IRepository<LikeBoxPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}