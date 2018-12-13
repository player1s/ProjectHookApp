using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System;
using System.Collections.Generic;

class Client
{/*
    static void Main(string[] args)
    {
        string s = GetData().GetAwaiter().GetResult();
        System.Console.WriteLine(s);
    }
    */
    public Client() { }
    public static async Task<string> Login(object obj)
    {
        string json = "whaatever";

        /*
        string json = JsonConvert.SerializeObject(obj);
        string url = "http://localhost:5000/api/values";
        HttpClient client = new HttpClient();
        */

        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:5000");
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("what", "login")
            });
            var result = await client.PostAsync("/api/values/5", content).ConfigureAwait(false);
            string resultContent = await result.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
        }
        return json;
    }
}

    /*
    var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
    var result = await client.PostAsync(url, content).ConfigureAwait(false);

   // string str = await client.GetStringAsync("http://localhost:5000/api/values/5").ConfigureAwait(false);
   */
