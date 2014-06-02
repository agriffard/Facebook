using System;
using System.Collections.Generic;
using System.Web;
using Orchard;
using Facebook.Models;

namespace Facebook.Services {
    public interface IFacebookService : IDependency {
        /// <summary>
        /// The Facebook settings
        /// </summary>
        FacebookSettingsPart SettingsPart { get; }
    }
}
