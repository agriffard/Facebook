using System.Web.Mvc;
using Orchard;
using Orchard.DisplayManagement;
using Orchard.Environment.Extensions;
using Orchard.Mvc.Filters;
using Orchard.UI.Resources;
using Facebook.Services;

namespace Facebook.Filters {
    [OrchardFeature("Facebook")]
    public class FacebookFilter : FilterProvider, IResultFilter {
        private readonly IResourceManager _resourceManager;
        private readonly IWorkContextAccessor _workContextAccessor;
        private readonly dynamic _shapeFactory;
        private readonly IFacebookService _facebookService;

        public FacebookFilter(
            IResourceManager resourceManager,
            IWorkContextAccessor workContextAccessor,
            IShapeFactory shapeFactory,
            IFacebookService facebookSuiteService) {
            _resourceManager = resourceManager;
            _workContextAccessor = workContextAccessor;
            _shapeFactory = shapeFactory;
            _facebookService = facebookSuiteService;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext) {
            if (!(filterContext.Result is ViewResult)) return;

            if (Orchard.UI.Admin.AdminFilter.IsApplied(filterContext.RequestContext)) return;
                        
            _workContextAccessor.GetContext(filterContext).Layout.Body.Items.Insert(0,
                    _shapeFactory.FacebookJsSdk(AppId: _facebookService.SettingsPart.AppId,
                    Culture: _workContextAccessor.GetContext(filterContext).CurrentCulture.Replace("-", "_"))
                );
        }

        public void OnResultExecuted(ResultExecutedContext filterContext) {
        }
    }
}