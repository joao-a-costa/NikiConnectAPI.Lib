﻿using System;
using System.Collections.Generic;
using System.Configuration;
using NikiConnectAPI.Lib.Interfaces;
using NikiConnectAPI.Test.Interfaces;

namespace NikiConnectAPI.Test
{
    public class App : IApp
    {
        public long Limit { get; set; }
        public string Url { get; set; }
        public string UrlVersion { get; set; }
        public string UrlToken { get; set; }
        public string UrlRemoteApiClientGet { get; set; }
        public string UrlRemoteApiClientGetByID { get; set; }
        public string UrlRemoteApiClientPost { get; set; }
        public string UrlFlyers { get; set; }
        public string UrlFlyersInclude { get; set; }
        public string UrlDocumentHeaders { get; set; }
        public string UrlDocumentHeadersInclude { get; set; }
        public string UrlUserAgent { get; set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
        public string XVersion { get; set; }
        public string XTenant { get; set; }
        public string XCompany { get; set; }
        public string DateFormat { get; set; }
        public static List<string> _FieldExternalId = new List<string>() { "ExternalId", "Matchcode" };
        public static List<Type> AttributeTypes { get; set; } = new List<Type>() { typeof(Lib.Attributes.EditableAttribute) };
        public static List<string> ListFieldsNotToInclude { get; set; } = new List<string>() { nameof(IBaseModel.Id) };
        public static List<string> ListFieldsToIncludeDelete { get; set; } = new List<string>() { nameof(IBaseModel.Id), "DeletedAd" };

        public App()
        {
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            Limit = long.TryParse(ConfigurationManager.AppSettings["Limit"], out long limit) ? limit : 9223372036854775807;
            Url = ConfigurationManager.AppSettings["Url"] ?? string.Empty;
            UrlVersion = ConfigurationManager.AppSettings["UrlVersion"] ?? string.Empty;
            UrlToken = ConfigurationManager.AppSettings["UrlToken"] ?? string.Empty;
            UrlRemoteApiClientGet = ConfigurationManager.AppSettings["UrlRemoteApiClientGet"] ?? string.Empty;
            UrlRemoteApiClientGetByID = ConfigurationManager.AppSettings["UrlRemoteApiClientGetByID"] ?? string.Empty;
            UrlRemoteApiClientPost = ConfigurationManager.AppSettings["UrlRemoteApiClientPost"] ?? string.Empty;
            UrlFlyers = ConfigurationManager.AppSettings["UrlFlyers"] ?? string.Empty;
            UrlFlyersInclude = ConfigurationManager.AppSettings["UrlFlyersInclude"] ?? string.Empty;
            UrlDocumentHeaders = ConfigurationManager.AppSettings["UrlDocumentHeaders"] ?? string.Empty;
            UrlDocumentHeadersInclude = ConfigurationManager.AppSettings["UrlDocumentHeadersInclude"] ?? string.Empty;
            UrlUserAgent = ConfigurationManager.AppSettings["UrlUserAgent"] ?? string.Empty;
            ClientID = ConfigurationManager.AppSettings["ClientID"] ?? string.Empty;
            ClientSecret = ConfigurationManager.AppSettings["ClientSecret"] ?? string.Empty;
            XVersion = ConfigurationManager.AppSettings["XVersion"] ?? string.Empty;
            XTenant = ConfigurationManager.AppSettings["XTenant"] ?? string.Empty;
            XCompany = ConfigurationManager.AppSettings["XCompany"] ?? string.Empty;
            DateFormat = ConfigurationManager.AppSettings["DateFormat"] ?? string.Empty;
        }
    }
}