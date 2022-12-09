using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace TranslateTest
{

    public static class Generate
    {

        public static string GetSRandomTrivia()
        {
            var url = $"http://numbersapi.com/random/trivia";

            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    string tmp = streamReader.ReadToEnd();
                    return tmp;
                    //var myDeserializedClass = JsonConvert.DeserializeObject<Root>(tmp);

                    //return myDeserializedClass.desc;
                }
            }
            else
            {
                return null;
            }
        }
        public static string GetSRandomYear()
        {
            var url = $"http://numbersapi.com/random/year";

            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    string tmp = streamReader.ReadToEnd();
                    return tmp;
                }
            }
            else
            {
                return null;
            }
        }
        public static string GetSCurrYear(string Number)
        {
            var url = $"http://numbersapi.com/{Number}/year";

            var request = WebRequest.Create(url);
            try
            {
                var response = request.GetResponse();
                var httpStatusCode = (response as HttpWebResponse).StatusCode;

                if (httpStatusCode == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        string tmp = streamReader.ReadToEnd();
                        return tmp;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return "Something wrong!";
            }

        }
        public static string GetSRandomDate()
        {
            var url = $"http://numbersapi.com/random/date";

            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    string tmp = streamReader.ReadToEnd();
                    return tmp;
                }
            }
            else
            {
                return null;
            }
        }
        public static string GetSRandomMath()
        {
            var url = $"http://numbersapi.com/random/math";

            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    string tmp = streamReader.ReadToEnd();
                    return tmp;
                }
            }
            else
            {
                return null;
            }
        }
        public static string GetSCurrMath(string Number)
        {
            var url = $"http://numbersapi.com/{Number}/math";

            var request = WebRequest.Create(url);
            try
            {
                var response = request.GetResponse();
                var httpStatusCode = (response as HttpWebResponse).StatusCode;

                if (httpStatusCode == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        string tmp = streamReader.ReadToEnd();
                        return tmp;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return "Something wrong!";
            }

        }

        public static string GetSCurrTrivia(string Number)
        {
            var url = $"http://numbersapi.com/{Number}";

            var request = WebRequest.Create(url);
            try
            {
                var response = request.GetResponse();
                var httpStatusCode = (response as HttpWebResponse).StatusCode;

                if (httpStatusCode == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        string tmp = streamReader.ReadToEnd();
                        return tmp;
                    }
                }
                else
                {
                    return null;
                }
            } catch
            {
                return "Something wrong!";
            }
            
        }
        public static string GetSCurrDate(string Date)
        {
            var url = $"http://numbersapi.com/{Date}/date";

            var request = WebRequest.Create(url);
            try
            {
                var response = request.GetResponse();
                var httpStatusCode = (response as HttpWebResponse).StatusCode;

                if (httpStatusCode == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        string tmp = streamReader.ReadToEnd();
                        return tmp;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return "Something wrong!";
            }

        }

        
    }
    
    public class Root
    {
        public string desc;
    }
}
