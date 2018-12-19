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


        internal static List<LogItem> ParseFile(string currentFile)
        {
            var fileString = File.ReadAllText(currentFile);
            // remove empty Lines
            fileString = Regex.Replace(fileString, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);

            var splittedLogs = Regex.Split(fileString, "------------------------------------------------------------------------------------------------");
            //var logItemString = Regex.Split(splittedLogs[10], "\r\n|\r|\n", RegexOptions.ExplicitCapture);
            return ParsLogs(splittedLogs);
        }

        private static List<LogItem> ParsLogs(string[] splittedLogs)
        {
            List<LogItem> result = new List<Models.LogItem>();
            if (splittedLogs.Any())
            {
                //   Regex datePattern = new Regex(@"Date:");
                Regex datePattern = new Regex(@"Date:(.+?)\r");
                Regex methodPattern = new Regex(@"Method Type:(.+?)\r");
                Regex headersPattern = new Regex(@"Request Headers Start:\r\n((.+\n)+)Request Headers End", RegexOptions.Multiline);
                Regex targetURLPattern = new Regex(@"Target URL:(.+?)\r");
                //Regex requestBodyPattern = new  Regex(@"Request Body:(.+?)\r");
                Regex requestBodyPattern = new Regex(@"Request Body:((.+\n)+)Response Body");
                Regex responseBodyPattern = new Regex(@"Response Body:(.+?)\r");
                Regex totalTimeInSecPattern = new Regex(@"Taken Total Seconds:(.+?)\r");
                foreach (var logItemString in splittedLogs)
                {
                    var item = Regex.Split(logItemString, "\r\n|\r|\n", RegexOptions.ExplicitCapture);

                    if (item.Length > 1)
                    {
                        var t = headersPattern.Match(logItemString).Groups[1].Value;//.Split(new string[] { "\r\n" }, StringSplitOptions.None);
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
                }
            }
            return result;
        }

        public  static string EscapeSpecialCharacters(string value)
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

        public static string EscapeLikeValue(string valueWithoutWildcards)
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
