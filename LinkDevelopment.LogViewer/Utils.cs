using LinkDevelopment.LogViewer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LinkDevelopment.LogViewer
{
    public class Utils
    {
        internal List<LogItem> ParseFile(string currentFile)
        {
            var fileString = File.ReadAllText(currentFile, Encoding.UTF8);
            //  var fileString = currentFile;
            // remove empty Lines

            List<LogItem> result = new List<Models.LogItem>();
            #region RegeX
            Regex datePattern = new Regex(@"Date:(.+?)\r");
            Regex methodPattern = new Regex(@"Method Type:(.+?)\r");
            Regex headersPattern = new Regex(@"Request Headers Start:\r\n((.+\n)+)Request Headers End", RegexOptions.Multiline);
            Regex targetURLPattern = new Regex(@"Target URL:(.+?)\r");
            //Regex requestBodyPattern = new  Regex(@"Request Body:(.+?)\r");
            Regex requestBodyPattern = new Regex(@"Request Body:((.+\n)+)Response Body");
            Regex responseBodyPattern = new Regex(@"Response Body:(.+?)\r");
            Regex totalTimeInSecPattern = new Regex(@"Taken Total Seconds:(.+?)\r");
            #endregion

            StringBuilder sb = new StringBuilder();
            using (FileStream fs = File.Open(currentFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                // temp vars 

                string line;
                var tempLogItem = new LogItem() { Id = new Guid() };
                string Id = string.Empty;
                DateTime Date = new DateTime();
                string TargetMethod = string.Empty;
                string TargetURL = string.Empty;
                string RequestHeaders = string.Empty;
                string RequestBody = string.Empty;
                string ResponseBody = string.Empty;
                string TakenTimeSeconds = string.Empty;


                bool logCaptured = false;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        if (line == "------------------------------------------------------------------------------------------------")
                        {

                            if (logCaptured)
                            {
                                result.Add(tempLogItem);
                            }
                            tempLogItem = new LogItem() { Id = new Guid() };
                            TargetMethod = string.Empty;
                            TargetURL = string.Empty;
                            RequestHeaders = string.Empty;
                            RequestBody = string.Empty;
                            ResponseBody = string.Empty;
                            TakenTimeSeconds = string.Empty;
                        }

                        if (line.IndexOf("Date:") == 0)
                            Date = DateTime.Parse(line.Split(new string[] { "Date:" }, StringSplitOptions.None)[1]);
                        else if (line.IndexOf("Date:") == 0)
                            Date = DateTime.Parse(line.Split(new string[] { "Date:" }, StringSplitOptions.None)[1]);



                    }

                }

            }


            fileString = Regex.Replace(fileString, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            var splittedLogs = Regex.Split(fileString, "------------------------------------------------------------------------------------------------");
            //var logItemString = Regex.Split(splittedLogs[10], "\r\n|\r|\n", RegexOptions.ExplicitCapture);


            return result;
            //return ParsLogs(splittedLogs);
        }

        private List<LogItem> ParsLogs(string[] splittedLogs)
        {
            List<LogItem> result = new List<Models.LogItem>();
            if (splittedLogs.Any())
            {
                //   Regex datePattern = new Regex(@"Date:");
                Regex datePattern = new Regex(@"Date:(.+?)");
                Regex methodPattern = new Regex(@"Method Type:(.+?)\r");
                Regex headersPattern = new Regex(@"Request Headers Start:\r\n((.+\n)+)Request Headers End", RegexOptions.Multiline);
                Regex targetURLPattern = new Regex(@"Target URL:(.+?)\r");
                //Regex requestBodyPattern = new  Regex(@"Request Body:(.+?)\r");
                Regex requestBodyPattern = new Regex(@"Request Body:((.+\n)+)Response Body");
                Regex responseBodyPattern = new Regex(@"Response Body:(.+?)\r");
                Regex totalTimeInSecPattern = new Regex(@"Taken Total Seconds:(.+?)\r");

                foreach (var logItemString in splittedLogs)
                {
                    //var item = Regex.Split(logItemString, "\r\n|\r|\n", RegexOptions.ExplicitCapture);

                    if (!string.IsNullOrEmpty(logItemString))
                    {
                        //var t = headersPattern.Match(logItemString).Groups[1].Value;//.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                        result.Add(new LogItem
                        {
                            Id = Guid.NewGuid(),
                            Date = DateTime.Parse(datePattern.Match(logItemString).Groups[1].Value),
                            TargetMethod = methodPattern.Match(logItemString).Groups[1].Value,
                            TargetURL = targetURLPattern.Match(logItemString).Groups[1].Value,
                            RequestHeaders = headersPattern.Match(logItemString).Groups[1].Value,
                            RequestBody = requestBodyPattern.Match(logItemString).Groups[1].Value,
                            ResponseBody = responseBodyPattern.Match(logItemString).Groups[1].Value,
                            TakenTimeSeconds = int.Parse(totalTimeInSecPattern.Match(logItemString).Groups[1].Value)

                        });
                    }
                    GC.SuppressFinalize(this);
                }
            }
            return result;
        }

        public string EscapeSpecialCharacters(string value)
        {
            StringBuilder sBuilder = new StringBuilder(value);

            string pattern = @"([-\]\[<>\?\*\\\""/\|\~\(\)\#/=><+\%&\^\'])";

            Regex expression = new Regex(pattern);

            if (expression.IsMatch(value))
            {
                sBuilder.Replace(@"\", @"\\");
                sBuilder.Replace("]", @"\]");
                sBuilder.Insert(0, "[");
                sBuilder.Append("]");
            }
            return sBuilder.ToString();
        }
        //public static  string EscapeLikeValue(string value)
        //{
        //    StringBuilder sb = new StringBuilder(value.Length);
        //    for (int i = 0; i < value.Length; i++)
        //    {
        //        char c = value[i];
        //        switch (c)
        //        {
        //            case ']':
        //            case '[':
        //            case '%':
        //            case '*':
        //            sb.Append("[").Append(c).Append("]");
        //            break;
        //            case '\'':
        //            sb.Append("''");
        //            break;
        //            default:
        //            sb.Append(c);
        //            break;
        //        }
        //    }
        //    return sb.ToString();
        //}

        public string EscapeLikeValue(string valueWithoutWildcards)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < valueWithoutWildcards.Length; i++)
            {
                char c = valueWithoutWildcards[i];
                if (c == '*' || c == '%' || c == '[' || c == ']')
                    sb.Append("[").Append(c).Append("]");
                else if (c == '\'')
                    sb.Append("''");
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
