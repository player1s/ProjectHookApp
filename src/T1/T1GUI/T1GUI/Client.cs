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
    public static async Task<string> PostLogin(object obj)
    {
        string responseInString;
        string json = JsonConvert.SerializeObject(obj);
        string url = "http://localhost:5000/api/login/";
        HttpClient client = new HttpClient();
        var result = await client.PostAsJsonAsync(url, json).ConfigureAwait(false);

        responseInString = await result.Content.ReadAsStringAsync();

        return responseInString;
    }

    public static async Task<string> PostCreateAcc(object obj)
    {
        string responseInString;
        string json = JsonConvert.SerializeObject(obj);
        string url = "http://localhost:5000/api/createacc/";
        HttpClient client = new HttpClient();
        var result = await client.PostAsJsonAsync(url, json).ConfigureAwait(false);

        responseInString = await result.Content.ReadAsStringAsync();

        return responseInString;
    }

    public static async Task<string> PostGetAll(object obj)
    {
        string responseInString;
        string json = JsonConvert.SerializeObject(obj);
        string url = "http://localhost:5000/api/getall/";
        HttpClient client = new HttpClient();
        var result = await client.PostAsJsonAsync(url, json).ConfigureAwait(false);

        responseInString = await result.Content.ReadAsStringAsync();

        return responseInString;
    }


}
