using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Facebook.Models;

namespace Facebook.Handlers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class RecommendationFeedPartHandler : ContentHandler
    {
        public RecommendationFeedPartHandler(IRepository<RecommendationFeedPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}