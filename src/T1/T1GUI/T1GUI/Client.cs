  using System.Threading.Tasks;
using System.Net.Http;
class Client
{/*
    static void Main(string[] args)
    {
        string s = GetData().GetAwaiter().GetResult();
        System.Console.WriteLine(s);
    }
    */
    public Client() {}
    public static async Task<string> GetData() 
    {



        HttpClient client = new HttpClient();

        string str = await client.GetStringAsync("http://localhost:5000/api/values/5");

        return str;
        
    }
}