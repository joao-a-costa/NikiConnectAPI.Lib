using System.ComponentModel;

namespace NikiConnectAPI.Lib.Models.Auth
{
    public class Header
    {
        [DisplayName("Authorization")]
        public string Authorization { get; set; }
        [DisplayName("X-Tenant")]
        public string XTenant { get; set; }
        [DisplayName("X-Version")]
        public string XVersion { get; set; }
        [DisplayName("X-CompanyID")]
        public string XCompanyID { get; set; }
    }
}
