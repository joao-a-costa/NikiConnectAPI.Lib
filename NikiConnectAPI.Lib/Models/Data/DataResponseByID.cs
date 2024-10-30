using System;

namespace NikiConnectAPI.Lib.Models.Data
{
    public class DataResponseByID<T> where T : class
    {
        public DataResultByID<T> DataResult { get; set; }
        public DataResultError Error { get; set; }
        public Exception Exception { get; set; }
    }
}