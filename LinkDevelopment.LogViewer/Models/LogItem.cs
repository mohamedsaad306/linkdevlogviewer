using System;
using System.Collections.Generic;

namespace LinkDevelopment.LogViewer.Models
{
    public class LogItem
    {
        public Guid Id { get; internal set; }
        public DateTime Date { get; set; }

        public string TargetURL { get; set; }
        public string TargetMethod { get; set; }

        public string RequestBody { get; set; }
        public string  ResponseBody { get; set; }

        public string RequestHeaders { get; set; }
        public Dictionary<string,string> ResponseHeaders { get; set; }

        public int TakenTimeSeconds { get; set; }
        public StatusEnum? Status { get; set; }
       
    }

    public enum StatusEnum
    {
        Fail=0,
        Sucess=1,
        Undefined=2,
    }
}
