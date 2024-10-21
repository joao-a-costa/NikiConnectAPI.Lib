using System;

namespace NikiConnectAPI.Lib.Models.Data
{
    public class DataResponse<T> where T : class
    {
        public DataResult<T> DataResult { get; set; }
        public DataResultError Error { get; set; }
        public Exception Exception { get; set; }
    }
}