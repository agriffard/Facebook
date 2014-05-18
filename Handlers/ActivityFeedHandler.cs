using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Facebook.Models;

namespace Facebook.Handlers
{
    public class ActivityFeedPartHandler : ContentHandler
    {
        public ActivityFeedPartHandler(IRepository<ActivityFeedPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}