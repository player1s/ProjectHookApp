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
        string responseInString;
        string json = JsonConvert.SerializeObject(obj);
        string url = "http://localhost:5000/api/values";
        HttpClient client = new HttpClient();
       // var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
        var result = await client.PostAsJsonAsync(url, json).ConfigureAwait(false);

        responseInString = await result.Content.ReadAsStringAsync();

        // string str = await client.GetStringAsync("http://localhost:5000/api/values/5").ConfigureAwait(false);
        return responseInString;
    }
}
