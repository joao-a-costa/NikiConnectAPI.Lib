using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("documentHeaders")]
    public class DocumentHeader : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("approvement_status")]
        public object ApprovementStatus { get; set; }

        [JsonProperty("pending_lines")]
        public object PendingLines { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("process_id")]
        public int ProcessId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; } = 1;

        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("address_id")]
        public int AddressId { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("external_account_id")]
        public int ExternalAccountId { get; set; }

        [JsonProperty("invoice_to")]
        public string InvoiceTo { get; set; }

        [JsonProperty("salutation_id")]
        public int SalutationId { get; set; }

        [JsonProperty("name_1")]
        public string Name1 { get; set; }

        [JsonProperty("name_2")]
        public object Name2 { get; set; }

        [JsonProperty("street_1")]
        public string Street1 { get; set; }

        [JsonProperty("street_2")]
        public string Street2 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        [JsonProperty("tax_ident_number")]
        public object TaxIdentNumber { get; set; }

        [JsonProperty("cost_center")]
        public object CostCenter { get; set; }

        [JsonProperty("cost_object")]
        public object CostObject { get; set; }

        [JsonProperty("external_reference")]
        public object ExternalReference { get; set; }

        [Editable(true)]
        [JsonProperty("header_message")]
        public string HeaderMessage { get; set; }

        [JsonProperty("footer_message")]
        public string FooterMessage { get; set; }

        [JsonProperty("total_gross_amount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("total_line_discount_amount")]
        public int TotalLineDiscountAmount { get; set; }

        [JsonProperty("discount_percent_1")]
        public int DiscountPercent1 { get; set; }

        [JsonProperty("discount_percent_2")]
        public int DiscountPercent2 { get; set; }

        [JsonProperty("discount_percent_3")]
        public int DiscountPercent3 { get; set; }

        [JsonProperty("discount_percent")]
        public int DiscountPercent { get; set; }

        [JsonProperty("discount_amount")]
        public int DiscountAmount { get; set; }

        [JsonProperty("total_net_discount")]
        public int TotalNetDiscount { get; set; }

        [JsonProperty("total_net_amount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("tax_region_id")]
        public int TaxRegionId { get; set; }

        [JsonProperty("total_tax_amount")]
        public double TotalTaxAmount { get; set; }

        [JsonProperty("total_additional_tax_amount")]
        public int TotalAdditionalTaxAmount { get; set; }

        [JsonProperty("total_additional_cost_amount")]
        public int TotalAdditionalCostAmount { get; set; }

        [JsonProperty("total_tax_included_amount")]
        public double TotalTaxIncludedAmount { get; set; }

        [JsonProperty("round_amount")]
        public int RoundAmount { get; set; }

        [JsonProperty("total_retention_amount")]
        public int TotalRetentionAmount { get; set; }

        [JsonProperty("total_amount")]
        public double TotalAmount { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("total_gross_weight")]
        public double TotalGrossWeight { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("payment_at")]
        public DateTime PaymentAt { get; set; }

        [JsonProperty("currency_id")]
        public int CurrencyId { get; set; }

        [JsonProperty("currency_rate")]
        public int CurrencyRate { get; set; }

        [JsonProperty("currency_factor")]
        public int CurrencyFactor { get; set; }

        [JsonProperty("carrier_id")]
        public int CarrierId { get; set; }

        [JsonProperty("load_street")]
        public string LoadStreet { get; set; }

        [JsonProperty("load_postal_code")]
        public string LoadPostalCode { get; set; }

        [JsonProperty("load_city")]
        public object LoadCity { get; set; }

        [JsonProperty("load_country_id")]
        public int LoadCountryId { get; set; }

        [JsonProperty("load_at")]
        public DateTime LoadAt { get; set; }

        [JsonProperty("warehouse_origin_id")]
        public int WarehouseOriginId { get; set; }

        [JsonProperty("warehouse_destination_id")]
        public object WarehouseDestinationId { get; set; }

        [JsonProperty("stock_date")]
        public string StockDate { get; set; }

        [JsonProperty("unload_street")]
        public string UnloadStreet { get; set; }

        [JsonProperty("unload_postal_code")]
        public string UnloadPostalCode { get; set; }

        [JsonProperty("unload_city")]
        public object UnloadCity { get; set; }

        [JsonProperty("unload_at")]
        public DateTime? UnloadAt { get; set; }

        [JsonProperty("unload_country_id")]
        public int UnloadCountryId { get; set; }

        [JsonProperty("signature_attachment_id")]
        public object SignatureAttachmentId { get; set; }

        [JsonProperty("delivery_at")]
        public DateTime? DeliveryAt { get; set; }

        [JsonProperty("closed_at")]
        public DateTime ClosedAt { get; set; }

        [JsonProperty("tracking_started_at")]
        public object TrackingStartedAt { get; set; }

        [JsonProperty("tracking_location")]
        public object TrackingLocation { get; set; }

        [JsonProperty("tracking_finished_at")]
        public object TrackingFinishedAt { get; set; }

        [JsonProperty("document_date")]
        public DateTime DocumentDate { get; set; }

        [JsonProperty("sync")]
        public int Sync { get; set; }

        [JsonProperty("transaction_closed")]
        public int TransactionClosed { get; set; }

        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("deleted_by")]
        public object DeletedBy { get; set; }

        [JsonProperty("closed_by")]
        public object ClosedBy { get; set; }

        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("external_id")]
        public object ExternalId { get; set; }
    }
}