using JetBrains.Annotations;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Facebook.Models;

namespace Facebook.Handlers
{
    [UsedImplicitly]
    public class FacebookSettingsPartHandler : ContentHandler
    {
        public FacebookSettingsPartHandler(IRepository<FacebookSettingsPartRecord> repository)
        {
            Filters.Add(new ActivatingFilter<FacebookSettingsPart>("Site"));
            Filters.Add(StorageFilter.For(repository));
        }
    }
}