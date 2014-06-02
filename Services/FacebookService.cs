using System;
using Facebook.Models;
using Orchard;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;
using Orchard.Mvc;
using Orchard.Settings;

namespace Facebook.Services {
    [OrchardFeature("Facebook")]
    public class FacebookService : IFacebookService {
        private readonly ISiteService _siteService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        
        public FacebookService(ISiteService siteService, IHttpContextAccessor httpContextAccessor) {
            _siteService = siteService;
            _httpContextAccessor = httpContextAccessor;
        }

        private FacebookSettingsPart _settingsPart;
        public FacebookSettingsPart SettingsPart {
            get {
                if (_settingsPart == null) {
                    _settingsPart = _siteService.GetSiteSettings().As<FacebookSettingsPart>();
                }
                return _settingsPart;
            }
        }
    }
}