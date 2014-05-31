using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Facebook.Models;

namespace Facebook.Handlers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class RecommendationBarPartHandler : ContentHandler
    {
        public RecommendationBarPartHandler(IRepository<RecommendationBarPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}