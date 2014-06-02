using Facebook.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;

namespace Facebook.Handlers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class FacebookLikeButtonPartHandler : ContentHandler {
        public FacebookLikeButtonPartHandler(IRepository<FacebookLikeButtonPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}