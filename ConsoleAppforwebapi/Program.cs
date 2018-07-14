using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1;

namespace ConsoleAppforwebapi
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Starting Webapi Connection!");
            HttpClient clt = new HttpClient();
            clt.BaseAddress = new Uri("http://localhost:21303/");
            clt.DefaultRequestHeaders.Accept.Clear();
            clt.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // MyAPIGet(clt).Wait();
            MyAPIPut(clt).Wait();
        }
        static async Task MyAPIGet(HttpClient cons)
        {
            using (cons)
            {
                HttpResponseMessage res = await cons.GetAsync("api/values/2");
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    EventMgmt tag = await res.Content.ReadAsAsync<EventMgmt>();

                    
                    Console.WriteLine("\n");
                    Console.WriteLine("---------------------Calling Get Operation------------------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("tagId    tagName          tagDescription");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("{0}\t{1}\t\t{2}", tag.EventID, tag.EventName, tag.EventLocation);
                    Console.ReadLine();
                }
            }
        }
        static async Task MyAPIPut(HttpClient cons)
        {
            using (cons)
            {
                HttpResponseMessage res = await cons.GetAsync("api/values/2");
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    // EventMgmt tag = await res.Content.ReadAsAsync<EventMgmt>();
                    EventMgmt tag = new EventMgmt();
                   // tag.EventID = "2";
                    tag.EventName = "House warming";
                    res =  cons.PutAsJsonAsync("api/values/2", "House warming22").Result;
                    Console.WriteLine("\n");
                    Console.WriteLine("---------------------Calling put Operation------------------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("tagId    tagName          tagDescription");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("{0}\t{1}\t\t{2}", tag.EventID, tag.EventName, tag.EventLocation);
                    Console.ReadLine();
                }
            }
        }
    }
}
