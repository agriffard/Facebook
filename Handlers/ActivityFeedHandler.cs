using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Facebook.Models;

namespace Facebook.Handlers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class ActivityFeedPartHandler : ContentHandler {
        public ActivityFeedPartHandler(IRepository<ActivityFeedPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}