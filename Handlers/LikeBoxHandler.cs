using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Facebook.Models;

namespace Facebook.Handlers
{
    public class LikeBoxPartHandler : ContentHandler
    {
        public LikeBoxPartHandler(IRepository<LikeBoxPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}