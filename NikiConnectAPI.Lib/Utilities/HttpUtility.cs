using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using NikiConnectAPI.Lib.Converters;
using static NikiConnectAPI.Lib.Enums;
using System.Text;

namespace NikiConnectAPI.Lib.Utilities
{
    public static class HttpUtility
    {
        public static async Task<(bool, T, U, string, string)> EXECUTEAsync<T, U>(string URI,
            string Parameters, string Method, object Body, Dictionary<string, string> Headers,
             string userAgent = "", string ContentType = "application/json", int TimeOut = 1200,
             SecurityProtocolType securityProtocolType = SecurityProtocolType.Tls12,
             string accept = "", RequestFormat requestFormat = RequestFormat.Json)
        {
            T SuccessObject = default;
            U ErrorResponse = default;
            string ErrorType = null;
            string ErrorDescription = null;

            string result = null;
            string contentType = string.Empty;

            try
            {
                if (!string.IsNullOrWhiteSpace(Parameters))
                    Parameters = "?" + Parameters;

                if (securityProtocolType != SecurityProtocolType.Tls12)
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = securityProtocolType;
                }

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI + Parameters);

                request.ContentType = ContentType;
                request.Method = Method;

                if (!string.IsNullOrEmpty(accept))
                    request.Accept = accept;

                if (!string.IsNullOrEmpty(userAgent))
                    request.UserAgent = userAgent;

                if (Headers != null && Headers.Any())
                    foreach (var header in Headers)
                        request.Headers.Add(header.Key, header.Value);

                request.Timeout = TimeOut;

                if (requestFormat == RequestFormat.Json)
                {
                    if (!string.IsNullOrEmpty(Body.ToString()))
                    {
                        using (var writer = new StreamWriter(await request.GetRequestStreamAsync()))
                        {
                            await writer.WriteAsync(Body.ToString());
                        }
                    }
                }
                if (requestFormat == RequestFormat.FormData)
                {
                    string boundary = "----WebKitFormBoundary" + DateTime.Now.Ticks.ToString("x"); // Generate a boundary
                    request.ContentType = $"multipart/form-data; boundary={boundary}";

                    using (var requestStream = await request.GetRequestStreamAsync())
                    {
                        var boundaryBytes = Encoding.UTF8.GetBytes($"--{boundary}\r\n");
                        var endBoundaryBytes = Encoding.UTF8.GetBytes($"\r\n--{boundary}--\r\n");

                        // Assuming data is a dictionary for form data
                        var formData = Body as Dictionary<string, string>;
                        if (formData != null)
                        {
                            foreach (var field in formData)
                            {
                                // Write boundary
                                await requestStream.WriteAsync(boundaryBytes, 0, boundaryBytes.Length);

                                // Write field
                                var fieldData = $"Content-Disposition: form-data; name=\"{field.Key}\"\r\n\r\n{field.Value}\r\n";
                                var fieldBytes = Encoding.UTF8.GetBytes(fieldData);
                                await requestStream.WriteAsync(fieldBytes, 0, fieldBytes.Length);
                            }
                        }

                        // Write the end boundary
                        await requestStream.WriteAsync(endBoundaryBytes, 0, endBoundaryBytes.Length);
                    }
                }

                using (var response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    contentType = response.ContentType;

                    using (var stream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            result = await reader.ReadToEndAsync();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                var errorMessage = $"HTTPUtility.EXECUTEAsync ErrorWebException: {ex.Message}. InnerException: {(ex.InnerException != null ? ex.InnerException.Message : string.Empty)}. StackTrace: {ex.StackTrace}.";
                var errorResponse = string.Empty;
                var contentTypeError = string.Empty;

                if (ex.Response != null)
                {
                    contentTypeError = ex.Response.ContentType;
                    using (var stream = ex.Response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            errorResponse = await reader.ReadToEndAsync();
                        }
                    }

                    ErrorDescription = errorMessage;
                }

                SuccessObject = default;
                ErrorType = ex.Status.ToString();
                if (string.IsNullOrEmpty(ErrorDescription))
                    ErrorDescription = $"{ErrorDescription}. {errorMessage}";

                // Check if the response is XML
                if (!string.IsNullOrEmpty(contentTypeError) && contentTypeError.ToLower().Contains("xml"))
                {
                    // Process the response as XML
                    ErrorResponse = XmlConverter.DeserializeXml<U>(errorResponse);
                }
                else
                {
                    // Process the response as JSON
                    ErrorResponse = JsonConvert.DeserializeObject<U>(errorResponse);
                }
                return (false, SuccessObject, ErrorResponse, ErrorType, ErrorDescription);
            }
            catch (Exception ex)
            {
                var errorMessage = $"HTTPUtility.EXECUTEAsync Error: {ex.Message}. InnerException: {(ex.InnerException != null ? ex.InnerException.Message : string.Empty)}. StackTrace: {ex.StackTrace}.";

                SuccessObject = default;
                ErrorType = "Exception";
                ErrorDescription = errorMessage;

                return (false, SuccessObject, ErrorResponse, ErrorType, ErrorDescription);
            }

            if (string.IsNullOrWhiteSpace(result))
                return (false, SuccessObject, ErrorResponse, ErrorType, ErrorDescription);

            // Check if the response is XML
            if (!string.IsNullOrEmpty(contentType) && contentType.ToLower().Contains("xml"))
            {
                // Process the response as XML
                SuccessObject = XmlConverter.DeserializeXml<T>(result);
            }
            else
            {
                // Process the response as JSON
                SuccessObject = JsonConvert.DeserializeObject<T>(result, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = new List<JsonConverter> {
                        new SafeDateTimeConverter(),
                        new FlyerAttachmentDetailUrlConverter()
                    }
                });
            }

            return (true, SuccessObject, ErrorResponse, ErrorType, ErrorDescription);
        }

    }
}
