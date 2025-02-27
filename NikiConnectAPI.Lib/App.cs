namespace NikiConnectAPI.Lib
{
    internal static class App
    {
        public const string _FieldSlug = "slug";
        public const string _ContentType = "application/x-www-form-urlencoded";
        public const string _Accept = "application/json";
        public const string _AuthorizationType = "Authorization";
        public const string _AuthorizationTypeValue = "Basic";
        public const string _GrantTypeClientCredentials = "grant_type=api-client-credentials";
        public const string _ApiGet = "GET";
        public const string _ApiPost = "POST";
        public const string _ApiPatch = "PATCH";
        public const int _ApiTimeout = 999999999;
        public const string _DateTimeFormat = "yyyy-MM-ddTHH:mm:sszzz";
    }
}