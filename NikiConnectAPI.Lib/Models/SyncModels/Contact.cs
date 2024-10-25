using System;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("contacts")]
    public class Contact : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("contact_type_id")]
        public int ContactTypeId { get; set; }

        [JsonProperty("address_id")]
        public int AddressId { get; set; }

        [JsonProperty("salutation_id")]
        public int? SalutationId { get; set; }

        [JsonProperty("academic_degree_id")]
        public int? AcademicDegreeId { get; set; }

        [JsonProperty("role_id")]
        public int? RoleId { get; set; }

        [JsonProperty("language_id")]
        public int LanguageId { get; set; }

        [JsonProperty("gender_id")]
        public int? GenderId { get; set; }

        [JsonProperty("department")]
        public object Department { get; set; }

        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [Editable(true)]
        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("first_name")]
        public object FirstName { get; set; }

        [JsonProperty("last_name")]
        public object LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("birthday_congrats")]
        public bool? BirthdayCongrats { get; set; }

        [JsonProperty("new_year_congrats")]
        public bool? NewYearCongrats { get; set; }

        [JsonProperty("phone_call_code")]
        public string PhoneCallCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile_call_code")]
        public string MobileCallCode { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("fax_call_code")]
        public string FaxCallCode { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public int? UpdatedBy { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }

        [JsonProperty("module_comments")]
        public string ModuleComments { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
    }
}