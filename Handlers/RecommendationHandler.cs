using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Facebook.Models;

namespace Facebook.Handlers
{
    public class RecommendationPartHandler : ContentHandler
    {
        public RecommendationPartHandler(IRepository<RecommendationPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}