namespace NikiConnectAPI.Lib
{
    internal class App
    {
        #region "Slugs"

        public const string _SlugCountries = "countries";

        #endregion

        public const string _ContentType = "application/x-www-form-urlencoded";
        public const string _AuthorizationType = "Authorization";
        public const string _AuthorizationTypeValue = "Basic";
        public const string _GrantTypeClientCredentials = "grant_type=api-client-credentials";


        public const string _ApiGet = "GET";
        public const string _ApiPost = "POST";
        public const int _ApiTimeout = 999999999;
    }
}