using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Facebook.Models;

namespace Facebook.Handlers {
    [OrchardFeature("Facebook.CommentsBox")]
    public class FacebookCommentsPartBoxHandler : ContentHandler {
        public FacebookCommentsPartBoxHandler(IRepository<FacebookCommentsBoxPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}