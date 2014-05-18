using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Web;
using Orchard;
using Orchard.ContentManagement;
using Facebook.Models;

namespace Facebook.Services
{
    public class FacebookService : IFacebookService
    {
        private readonly IOrchardServices _orchardServices;

        private const string FacebookCredentialsTableName = "webpages_FacebookCredentials";
        private const string FacebookCredentialsIdColumn = "FacebookId";
        private const string FacebookCredentialsUserIdColumn = "UserId";

        private const string DefaultUserIdColumn = "UserId";
        private const string DefaultUserNameColumn = "email";
        private const string DefaultUserTableName = "UserProfile";

        private const string DefaultFacebookPerms = "email";
        private const string DefaultCallbackUrl = "~/Facebook/Login";
        private const string FacebookApiProfileUrl = "https://graph.facebook.com/me";

        private const string InitializedExceptionMessage = "The Facebook Module has not been initialized.";
        private const string ArgumentNullExceptionMessage = "Argument cannot be null or empty.";
        private const string ApiErrorMessage = "Facebook API error: {0}";

        private string _appId = null;
        private string _appSecret = null;
        private string _language = null;
        private bool _initialized = false;

        public FacebookService(IOrchardServices orchardServices)
        {
            _orchardServices = orchardServices;

            var settings = _orchardServices.WorkContext.CurrentSite.As<FacebookSettingsPart>().Record;
            _appId = settings.AppId;
            _appSecret = settings.AppSecret;
        }

        public string AppId
        {
            get
            {
                return _appId;
            }

            private set
            {
                _appId = value;
            }
        }

        public string AppSecret
        {
            get
            {
                return _appSecret;
            }

            private set
            {
                _appId = value;
            }
        }

        public string Language
        {
            get
            {
                return (_language ?? "en_US");
            }

            set
            {
                _language = value;
            }
        }

        private bool Initialized
        {
            get
            {
                return _initialized;
            }

            set
            {
                _initialized = value;
            }
        }

        /// <summary>
        /// Initializes the Facebook.
        /// </summary>
        /// <param name="appId">The AppId.</param>
        /// <param name="appId">The AppSecret.</param>
        public void Initialize(string appId, string appSecret)
        {
            if (String.IsNullOrEmpty(appId))
            {
                throw new ArgumentException(ArgumentNullExceptionMessage, "appId");
            }

            AppId = appId;

            if (String.IsNullOrEmpty(appSecret))
            {
                throw new ArgumentException(ArgumentNullExceptionMessage, "appSecret");
            }
            
            AppSecret = appSecret;

            Initialized = true;
        }

        /////<summary>
        ///// Retrieves the Facebook profile of a user.
        /////</summary>
        //public UserProfile GetFacebookUserProfile()
        //{
        //    var accessToken = GetFacebookCookieInfo("access_token");

        //    if (accessToken.IsEmpty())
        //    {
        //        return null;
        //    }

        //    var userProfileUrl = new Uri(string.Format("{0}?access_token={1}", FacebookApiProfileUrl, accessToken));

        //    var receiveStream = new WebClient().OpenRead(userProfileUrl);
        //    var result = new StreamReader(receiveStream).ReadToEnd();
        //    var profile = Json.Decode<UserProfile>(result);

        //    return profile;
        //}

        //private string GetFacebookCookieInfo(string key)
        //{
        //    var request = HttpContext.Current.Request;
        //    var name = string.Format("fbs_{0}", AppId);

        //    if (request.Cookies[name] != null)
        //    {
        //        var value = request.Cookies[name].Value;
        //        var args = HttpUtility.ParseQueryString(value.Replace("\"", ""));

        //        if (!IsFacebookCookieValid(args))
        //        {
        //            throw new SecurityException("Invalid Facebook cookie.");
        //        }

        //        return args[key];
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}

        //private static bool IsFacebookCookieValid(NameValueCollection args)
        //{
        //    var payload = new StringBuilder();
        //    foreach (var key in args.AllKeys)
        //    {
        //        if (key != "sig")
        //        {
        //            payload.AppendFormat("{0}={1}", key, args[key]);
        //        }
        //    }

        //    payload.Append(AppSecret);

        //    var md5 = System.Security.Cryptography.MD5CryptoServiceProvider.Create();
        //    var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(payload.ToString()));
        //    var signature = new StringBuilder();
        //    for (int i = 0; i < hash.Length; i++)
        //    {
        //        signature.Append(hash[i].ToString("X2"));
        //    }

        //    return string.Equals(args["sig"], signature.ToString(), StringComparison.InvariantCultureIgnoreCase);
        //}
    }
}
