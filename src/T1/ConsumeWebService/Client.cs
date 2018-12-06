  using System.Threading.Tasks;
using System.Net.Http;
class Client
{
    static void Main(string[] args)
    {
        string s = GetData().GetAwaiter().GetResult();
        System.Console.WriteLine(s);
    }
    static async Task<string> GetData() 
    {



        HttpClient client = new HttpClient();

        string str = await client.GetStringAsync("http://localhost:5000/api/values/4");

        return str;
        
    }
}