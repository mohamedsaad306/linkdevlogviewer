using LinkDevelopment.LogViewer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                Regex datePattern = new Regex(@"Date: (.+?)\r");
                Regex targetURLPattern = new Regex(@"Method Name: (.+?)\r");
                Regex requestBodyPattern = new Regex(@"Request Body: (.+?)\r");
                Regex responseBodyPattern = new Regex(@"Request Response:(.+?)\r");
                Regex totalTimeInSecPattern = new Regex(@"Taken Total Seconds:(.+?)\r");

                foreach (var logItemString in splittedLogs)
                {
                    var item = Regex.Split(logItemString, "\r\n|\r|\n", RegexOptions.ExplicitCapture);

                    if (item.Length > 1)
                    {
                        result.Add(new LogItem
                        {
                            Date = DateTime.Parse(datePattern.Match(logItemString).Groups[1].Value),
                            TargetURL = targetURLPattern.Match(logItemString).Groups[1].Value,
                            RequestBody = requestBodyPattern.Match(logItemString).Groups[1].Value,
                            ResponseBody = responseBodyPattern.Match(logItemString).Groups[1].Value,
                            TakenTimeSeconds = int.Parse(totalTimeInSecPattern.Match(logItemString).Groups[1].Value)

                        });
                    }
                }
            }
            return result;
        }
    }
}
