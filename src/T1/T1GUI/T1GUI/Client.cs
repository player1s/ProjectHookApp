using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System;
using System.Collections.Generic;

class Client
{
    public Client() { }
    /* 
     * The PostLogin method is responsible to communicate with the webapi on the logic layer, to execute the login process
     * it does so by: 
     * -taking an object as an argument
     * -Serialize it to the Json format using Newtonsoft
     * -Send it via HttpClient as a HTTPS request ( also sets the ConfigureAwait to false, to avoid a deadlock that would happen without configuring it)
     * -receive the response in a var, then convert it to String
     * -then return the mentioned string
     */
    public static async Task<string> PostLogin(object obj)
    {
        string responseInString;
        string json = JsonConvert.SerializeObject(obj);
        string url = "https://localhost:5001/api/login/";
        HttpClient client = new HttpClient();
        var result = await client.PostAsJsonAsync(url, json).ConfigureAwait(false);

        responseInString = await result.Content.ReadAsStringAsync();

        return responseInString;
    }
    /* 
    * The PostCreateAcc method is responsible to communicate with the webapi on the logic layer, to execute the account creation process
    * it does so by: 
    * -taking an object as an argument
    * -Serialize it to the Json format using Newtonsoft
    * -Send it via HttpClient as a HTTPS request ( also sets the ConfigureAwait to false, to avoid a deadlock that would happen without configuring it)
    * -receive the response in a var, then convert it to String
    * -then return the mentioned string
    */
    public static async Task<string> PostCreateAcc(object obj)
    {
        string responseInString;
        string json = JsonConvert.SerializeObject(obj);
        string url = "https://localhost:5001/api/createacc/";
        HttpClient client = new HttpClient();
        var result = await client.PostAsJsonAsync(url, json).ConfigureAwait(false);

        responseInString = await result.Content.ReadAsStringAsync();

        return responseInString;
    }
    /* 
    * The PostGetAll method is responsible to communicate with the webapi on the logic layer, to execute the process of returning all (but the requesting) users
    * it does so by: 
    * -taking an object as an argument
    * -Serialize it to the Json format using Newtonsoft
    * -Send it via HttpClient as a HTTPS request ( also sets the ConfigureAwait to false, to avoid a deadlock that would happen without configuring it)
    * -receive the response in a var, then convert it to String
    * -then return the mentioned string
    */
    public static async Task<string> PostGetAll(object obj)
    {
        string responseInString;
        string json = JsonConvert.SerializeObject(obj);
        string url = "https://localhost:5001/api/getall/";
        HttpClient client = new HttpClient();
        var result = await client.PostAsJsonAsync(url, json).ConfigureAwait(false);

        responseInString = await result.Content.ReadAsStringAsync();

        return responseInString;
    }


}
