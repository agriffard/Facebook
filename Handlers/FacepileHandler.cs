﻿using Facebook.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;

namespace Facebook.Handlers {
    [OrchardFeature("Facebook.SocialPlugins")]
    public class FacepilePartHandler : ContentHandler {
        public FacepilePartHandler(IRepository<FacepilePartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}