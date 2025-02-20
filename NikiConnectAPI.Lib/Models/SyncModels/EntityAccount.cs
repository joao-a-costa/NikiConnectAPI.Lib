using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Attributes;
using NikiConnectAPI.Lib.Interfaces;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    [System.ComponentModel.DisplayName("entityAccounts")]
    public class EntityAccount : IBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [Editable(true)]
        [JsonProperty("matchcode")]
        public string Matchcode { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("address_id")]
        public int AddressId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("revision_id")]
        public int RevisionId { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("bookable_up_to")]
        public object BookableUpTo { get; set; }

        [JsonProperty("last_movement")]
        public string LastMovement { get; set; }

        [JsonProperty("currency_id")]
        public int CurrencyId { get; set; }

        [JsonProperty("invoice_id")]
        public object InvoiceId { get; set; }

        [JsonProperty("cost_center_id")]
        public int CostCenterId { get; set; }

        [JsonProperty("profit_center_id")]
        public int ProfitCenterId { get; set; }

        [JsonProperty("tax_region_id")]
        public int TaxRegionId { get; set; }

        [JsonProperty("tin_country_id")]
        public int TinCountryId { get; set; }

        [JsonProperty("tax_ident_number")]
        public string TaxIdentNumber { get; set; }

        [JsonProperty("local_tax_number")]
        public string LocalTaxNumber { get; set; }

        [JsonProperty("price_list_id")]
        public int PriceListId { get; set; }

        [JsonProperty("item_price_line_id")]
        public int ItemPriceLineId { get; set; }

        [JsonProperty("contract_price_id")]
        public object ContractPriceId { get; set; }

        [JsonProperty("price_decimal_places")]
        public int PriceDecimalPlaces { get; set; }

        [JsonProperty("recommended_price_line_id")]
        public object RecommendedPriceLineId { get; set; }

        [JsonProperty("block_all_discounts")]
        public bool BlockAllDiscounts { get; set; }

        [JsonProperty("global_discount")]
        public int GlobalDiscount { get; set; }

        [JsonProperty("discount_per_line")]
        public int DiscountPerLine { get; set; }

        [JsonProperty("discount_group_creditor_id")]
        public object DiscountGroupCreditorId { get; set; }

        [JsonProperty("payment_type_id")]
        public int PaymentTypeId { get; set; }

        [JsonProperty("payment_condition_id")]
        public int PaymentConditionId { get; set; }

        [JsonProperty("participate_automatic_payments")]
        public bool ParticipateAutomaticPayments { get; set; }

        [JsonProperty("payments_bank_account_id")]
        public object PaymentsBankAccountId { get; set; }

        [JsonProperty("direct_debit_bank_account_id")]
        public object DirectDebitBankAccountId { get; set; }

        [JsonProperty("credit_amount")]
        public double CreditAmount { get; set; }

        [JsonProperty("credit_overdue_days")]
        public int CreditOverdueDays { get; set; }

        [JsonProperty("credit_quantity_invoices")]
        public object CreditQuantityInvoices { get; set; }

        [JsonProperty("block_for_deliveries")]
        public bool BlockForDeliveries { get; set; }

        [JsonProperty("shipping_method_id")]
        public int ShippingMethodId { get; set; }

        [JsonProperty("shipping_type_id")]
        public int ShippingTypeId { get; set; }

        [JsonProperty("shipping_speed_id")]
        public int ShippingSpeedId { get; set; }

        [JsonProperty("transport_mode_id")]
        public int TransportModeId { get; set; }

        [JsonProperty("estimated_delivery")]
        public object EstimatedDelivery { get; set; }

        [JsonProperty("process_on_intrastat")]
        public bool ProcessOnIntrastat { get; set; }

        [JsonProperty("incoterm_id")]
        public int IncotermId { get; set; }

        [JsonProperty("business_transaction_type_id")]
        public object BusinessTransactionTypeId { get; set; }

        [JsonProperty("destination_port_id")]
        public int DestinationPortId { get; set; }

        [JsonProperty("representative_id")]
        public int? RepresentativeId { get; set; }

        [JsonProperty("service_manager_id")]
        public object ServiceManagerId { get; set; }

        [JsonProperty("commercial_agent_id")]
        public int? CommercialAgentId { get; set; }

        [JsonProperty("document_language_id")]
        public int DocumentLanguageId { get; set; }

        [JsonProperty("document_form_id")]
        public object DocumentFormId { get; set; }

        [JsonProperty("edi_enabled")]
        public bool EdiEnabled { get; set; }

        [JsonProperty("edi_email")]
        public object EdiEmail { get; set; }

        [JsonProperty("send_invoice_enabled")]
        public bool SendInvoiceEnabled { get; set; }

        [JsonProperty("invoice_email")]
        public object InvoiceEmail { get; set; }

        [JsonProperty("send_reminder_enabled")]
        public bool SendReminderEnabled { get; set; }

        [JsonProperty("reminder_email")]
        public object ReminderEmail { get; set; }

        [JsonProperty("send_account_report_enabled")]
        public bool SendAccountReportEnabled { get; set; }

        [JsonProperty("account_report_email")]
        public object AccountReportEmail { get; set; }

        [JsonProperty("send_debts_report_enabled")]
        public bool SendDebtsReportEnabled { get; set; }

        [JsonProperty("debts_report_email")]
        public object DebtsReportEmail { get; set; }

        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        //[JsonProperty("updated_by")]
        //public int UpdatedBy { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        //[JsonProperty("updated_at")]
        //public DateTime? UpdatedAt { get; set; }

        [JsonProperty("module_comments")]
        public object ModuleComments { get; set; }
    }
}