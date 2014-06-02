using System;
using System.Web.Mvc;
using Facebook.Services;
using Orchard;
using Orchard.Localization;
using Orchard.Mvc.Extensions;
using Orchard.Security;
using Orchard.UI.Notify;
using Orchard.Utility.Extensions;

namespace Facebook.Controllers {
    [ValidateInput(false)]
    public class AdminController : Controller {
        private readonly IFacebookService _FacebookService;

        public AdminController(
            IFacebookService FacebookService,
            IOrchardServices services) {
            _FacebookService = FacebookService;
            Services = services;
            T = NullLocalizer.Instance;
        }

        public IOrchardServices Services { get; set; }
        public Localizer T { get; set; }
    }
}
