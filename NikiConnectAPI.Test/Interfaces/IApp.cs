namespace NikiConnectAPI.Test.Interfaces
{
    public interface IApp
    {
        string ClientID { get; set; }
        string ClientSecret { get; set; }
        string DateFormat { get; set; }
        long Limit { get; set; }
        string Url { get; set; }
        string UrlRemoteApiClientModels { get; set; }
        string UrlRemoteApiClientUpsert { get; set; }
        string UrlToken { get; set; }
        string UrlUserAgent { get; set; }
        string UrlVersion { get; set; }
        string XCompany { get; set; }
        string XTenant { get; set; }
        string XVersion { get; set; }
    }
}