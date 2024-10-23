namespace NikiConnectAPI.Lib.Models.Auth
{
    public class TokenResponse
    {
        public Token Token { get; set; }
        public TokenError TokenError { get; set; }
    }
}
