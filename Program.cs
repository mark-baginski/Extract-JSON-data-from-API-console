using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MarkBaginskiITVET
{
    class Program
    {
        public class SearchResult
        {
            public decimal value { get; set; }
            public string dateTime { get; set; }
        }

        static void Main(string[] args)
        {

            ///////////////////////// START 5151TH      //////////////////////////
            // API with big limit, Date range from 7 days ago to Start Date today (28/04/17) for station 5151TH
            string Url5151TH = "http://environment.data.gov.uk/flood-monitoring/id/stations/5151TH/readings?_sorted&_limit=10000&startdate=2017-04-22&enddate=2017-04-28";

            //Send the web request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url5151TH);
            //Get the Response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //stream
            Stream responseStream = response.GetResponseStream();
            //Stream Reader
            StreamReader readerStream = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));

            string json = readerStream.ReadToEnd();

            //Close
             readerStream.Close();

            var json1 = JObject.Parse(json);

            //get child values of json
            IList<JToken> results = json1["items"].Children().ToList();

            // json to .NET obj
            IList<SearchResult> searchResults = new List<SearchResult>();
            foreach (JToken result in results)
            {
                SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                searchResults.Add(searchResult);
            }

            // get all values of water
            decimal resultnumber = 0;

            //count how many results for mean value
            int resultMean = 0;

            // get min and max into lists
            List<decimal> Min1 = new List<decimal>();
            List<decimal> Max1 = new List<decimal>();

            // station
            Console.WriteLine("Station: 5151TH");

            foreach (SearchResult item in searchResults)
            {
                resultnumber = resultnumber + item.value;

                resultMean = resultMean + 1;

                Min1.Add(item.value);

                Max1.Add(item.value);

            }

            // average
            Console.WriteLine("Average =" +  resultnumber / resultMean);

            // min
            Console.WriteLine("Max =" + Min1.Max());

            // max
            Console.WriteLine("Min =" + Max1.Min());

            // date of min
            decimal var1;
            var1 = Min1.Min();
            IEnumerable<JToken> MAX101 = json1.SelectTokens("$..items[?(@.value == " + var1 + " )].dateTime");
            int processed = 0;
            foreach (JToken item in MAX101)
            {
                  Console.WriteLine("Min Date=" + item);
                if (++processed == 1) break;
            }

            // date of max
            decimal var2;
            var2 = Min1.Max();
            IEnumerable<JToken> MAX102 = json1.SelectTokens("$..items[?(@.value == " + var2 + " )].dateTime");
             processed = 0;
            foreach (JToken item in MAX102)
            {
                Console.WriteLine("Max Date=" + item);
                Console.WriteLine();
                if (++processed == 1) break;
            }
            ///////////////////////// END 5151TH      //////////////////////////




            ///////////////////////// START 5141TH      //////////////////////////

            // API with big limit, Date range from 7 days ago to Start Date today (28/04/17) for station 5141TH
            string Url5141TH = "http://environment.data.gov.uk/flood-monitoring/id/stations/5141TH/readings?_sorted&_limit=10000&startdate=2017-04-22&enddate=2017-04-28";

            //Send the web request
            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(Url5141TH);
            //Get the response2
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();

            //stream
            Stream responseStream2 = response2.GetResponseStream();
            //Stream Reader
            StreamReader readerStream2 = new StreamReader(responseStream2, System.Text.Encoding.GetEncoding("utf-8"));

            string json2 = readerStream2.ReadToEnd();

            //Close
            readerStream2.Close();

            var jn1 = JObject.Parse(json2);

            //get child values of json
            IList<JToken> results2 = jn1["items"].Children().ToList();

            // json to .NET obj
            IList<SearchResult> searchResults2 = new List<SearchResult>();
            foreach (JToken result in results2)
            {
                SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                searchResults2.Add(searchResult);
            }

            // get all values of water
           resultnumber = 0;

            //count how many results for mean value
            resultMean = 0;

            // get min and max into lists
            List<decimal> Min2 = new List<decimal>();
            List<decimal> Max2 = new List<decimal>();

            // station
            Console.WriteLine("Station: 5141TH");

            foreach (SearchResult item in searchResults2)
            {
                resultnumber = resultnumber + item.value;

                resultMean = resultMean + 1;

                Min2.Add(item.value);

                Max2.Add(item.value);

            }

            // average
            Console.WriteLine("Average =" + resultnumber / resultMean);

            // min
            Console.WriteLine("Max =" + Min2.Max());

            // max
            Console.WriteLine("Min =" + Max2.Min());

            // date of min
            decimal var3;
            var3 = Min2.Min();
            IEnumerable<JToken> MAX1012 = jn1.SelectTokens("$..items[?(@.value == " + var3 + " )].dateTime");
            processed = 0;
            foreach (JToken item in MAX1012)
            {
                Console.WriteLine("Min Date=" + item);
                if (++processed == 1) break;
            }

            // date of max
            decimal var4;
            var4 = Min2.Max();
            IEnumerable<JToken> MAX1022 = jn1.SelectTokens("$..items[?(@.value == " + var4 + " )].dateTime");
            processed = 0;
            foreach (JToken item in MAX1022)
            {
                Console.WriteLine("Max Date=" + item);
                Console.WriteLine();
                if (++processed == 1) break;
            }


            ///////////////////////// END 5151TH      //////////////////////////







            ///////////////////////// START 5171TH      //////////////////////////

            // API with big limit, Date range from 7 days ago to Start Date today (28/04/17) for station 5171TH
            string Url5171TH = "http://environment.data.gov.uk/flood-monitoring/id/stations/5171TH/readings?_sorted&_limit=10000&startdate=2017-04-22&enddate=2017-04-28";

            //Send the web request
            HttpWebRequest request21 = (HttpWebRequest)WebRequest.Create(Url5171TH);
            //Get the response
            HttpWebResponse response21 = (HttpWebResponse)request21.GetResponse();

            //stream
            Stream responseStream21 = response21.GetResponseStream();
            //Stream Reader
            StreamReader readerStream21 = new StreamReader(responseStream21, System.Text.Encoding.GetEncoding("utf-8"));

            string json21 = readerStream21.ReadToEnd();

            //Close
            readerStream21.Close();

            var jn11 = JObject.Parse(json21);

            //get child values of json
            IList<JToken> results21 = jn11["items"].Children().ToList();

            // json to .NET obj
            IList<SearchResult> searchResults21 = new List<SearchResult>();
            foreach (JToken result in results21)
            {
                SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                searchResults21.Add(searchResult);
            }

            // get all values of water
            resultnumber = 0;

            //count how many results for mean value
            resultMean = 0;

            // get min and max into lists
            List<decimal> Min21 = new List<decimal>();
            List<decimal> Max21 = new List<decimal>();

            // station
            Console.WriteLine("Station: 5171TH");

            foreach (SearchResult item in searchResults21)
            {
                resultnumber = resultnumber + item.value;

                resultMean = resultMean + 1;

                Min21.Add(item.value);

                Max21.Add(item.value);

            }

            // average
            Console.WriteLine("Average =" + resultnumber / resultMean);

            // min
            Console.WriteLine("Max =" + Min21.Max());

            // max
            Console.WriteLine("Min =" + Max21.Min());

            // date of min
            decimal var31;
            var31 = Min21.Min();
            IEnumerable<JToken> MAX10121 = jn11.SelectTokens("$..items[?(@.value == " + var31 + " )].dateTime");
            processed = 0;
            foreach (JToken item in MAX10121)
            {
                Console.WriteLine("Min Date=" + item);
                if (++processed == 1) break;
            }

            // date of max
            decimal var41;
            var41 = Min21.Max();
            IEnumerable<JToken> MAX10221 = jn11.SelectTokens("$..items[?(@.value == " + var41 + " )].dateTime");
            processed = 0;
            foreach (JToken item in MAX10221)
            {
                Console.WriteLine("Max Date=" + item);
                Console.WriteLine();
                if (++processed == 1) break;
            }


            ///////////////////////// END 5171TH      //////////////////////////








            ///////////////////////// START 5190TH      //////////////////////////

            // API with big limit, Date range from 7 days ago to Start Date today (28/04/17) for station 5171TH
            string Url5190TH = "http://environment.data.gov.uk/flood-monitoring/id/stations/5190TH/readings?_sorted&_limit=10000&startdate=2017-04-22&enddate=2017-04-28";

            //Send the web request
            HttpWebRequest request211 = (HttpWebRequest)WebRequest.Create(Url5190TH);
            //Get the response
            HttpWebResponse response211 = (HttpWebResponse)request211.GetResponse();

            //stream
            Stream responseStream211 = response211.GetResponseStream();
            //Stream Reader
            StreamReader readerStream211 = new StreamReader(responseStream211, System.Text.Encoding.GetEncoding("utf-8"));

            string json211 = readerStream211.ReadToEnd();

            //Close
            readerStream211.Close();

            var jn111 = JObject.Parse(json211);

            //get child values of json
            IList<JToken> results211 = jn111["items"].Children().ToList();

            // json to .NET obj
            IList<SearchResult> searchResults211 = new List<SearchResult>();
            foreach (JToken result in results211)
            {
                SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                searchResults211.Add(searchResult);
            }

            // get all values of water
            resultnumber = 0;

            //count how many results for mean value
            resultMean = 0;

            // get min and max into lists
            List<decimal> Min211 = new List<decimal>();
            List<decimal> Max211 = new List<decimal>();

            // station
            Console.WriteLine("Station: 5190TH");

            foreach (SearchResult item in searchResults211)
            {
                resultnumber = resultnumber + item.value;

                resultMean = resultMean + 1;

                Min211.Add(item.value);

                Max211.Add(item.value);

            }

            // average
            Console.WriteLine("Average =" + resultnumber / resultMean);

            // min
            Console.WriteLine("Max =" + Min211.Max());

            // max
            Console.WriteLine("Min =" + Max211.Min());

            // date of min
            decimal var311;
            var311 = Min211.Min();
            IEnumerable<JToken> MAX101211 = jn111.SelectTokens("$..items[?(@.value == " + var311 + " )].dateTime");
            processed = 0;
            foreach (JToken item in MAX101211)
            {
                Console.WriteLine("Min Date=" + item);
                if (++processed == 1) break;
            }

            // date of max
            decimal var411;
            var411 = Min211.Max();
            IEnumerable<JToken> MAX102211 = jn111.SelectTokens("$..items[?(@.value == " + var411 + " )].dateTime");
            processed = 0;
            foreach (JToken item in MAX102211)
            {
                Console.WriteLine("Max Date=" + item);
                Console.WriteLine();
                if (++processed == 1) break;
            }


            ///////////////////////// END 5190TH      //////////////////////////







            ///////////////////////// START 5112TH      //////////////////////////

            // API with big limit, Date range from 7 days ago to Start Date today (28/04/17) for station 5112TH
            string Url5112TH = "http://environment.data.gov.uk/flood-monitoring/id/stations/5112TH/readings?_sorted&_limit=10000&startdate=2017-04-22&enddate=2017-04-28";

            //Send the web request
            HttpWebRequest request2111 = (HttpWebRequest)WebRequest.Create(Url5112TH);
            //Get the response
            HttpWebResponse response2111 = (HttpWebResponse)request2111.GetResponse();

            //stream
            Stream responseStream2111 = response2111.GetResponseStream();
            //Stream Reader
            StreamReader readerStream2111 = new StreamReader(responseStream2111, System.Text.Encoding.GetEncoding("utf-8"));

            string json2111 = readerStream2111.ReadToEnd();

            //Close
            readerStream2111.Close();

            var jn1111 = JObject.Parse(json2111);

            //get child values of json
            IList<JToken> results2111 = jn1111["items"].Children().ToList();

            // json to .NET obj
            IList<SearchResult> searchResults2111 = new List<SearchResult>();
            foreach (JToken result in results2111)
            {
                SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                searchResults2111.Add(searchResult);
            }

            // get all values of water
            resultnumber = 0;

            //count how many results for mean value
            resultMean = 0;

            // get min and max into lists
            List<decimal> Min2111 = new List<decimal>();
            List<decimal> Max2111 = new List<decimal>();

            // station
            Console.WriteLine("Station: 5112TH");

            foreach (SearchResult item in searchResults2111)
            {
                resultnumber = resultnumber + item.value;

                resultMean = resultMean + 1;

                Min2111.Add(item.value);

                Max2111.Add(item.value);

            }

            // average
            Console.WriteLine("Average =" + resultnumber / resultMean);

            // min
            Console.WriteLine("Max =" + Min2111.Max());

            // max
            Console.WriteLine("Min =" + Max2111.Min());

            // date of min
            decimal var3111;
            var3111 = Min2111.Min();
            IEnumerable<JToken> MAX1012111 = jn1111.SelectTokens("$..items[?(@.value == " + var3111 + " )].dateTime");
            processed = 0;
            foreach (JToken item in MAX1012111)
            {
                Console.WriteLine("Min Date=" + item);
                if (++processed == 1) break;
            }

            // date of max
            decimal var4111;
            var4111 = Min2111.Max();
            IEnumerable<JToken> MAX1022111 = jn1111.SelectTokens("$..items[?(@.value == " + var4111 + " )].dateTime");
            processed = 0;
            foreach (JToken item in MAX1022111)
            {
                Console.WriteLine("Max Date=" + item);
                Console.WriteLine();
                if (++processed == 1) break;
            }


            ///////////////////////// END 5112TH      //////////////////////////



            Console.ReadKey();

        }
    
    }
}

