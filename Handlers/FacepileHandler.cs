using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Facebook.Models;

namespace Facebook.Handlers
{
    public class FacepilePartHandler : ContentHandler
    {
        public FacepilePartHandler(IRepository<FacepilePartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}