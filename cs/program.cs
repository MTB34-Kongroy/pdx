using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://script.google.com/macros/s/AKfycbzKzczq5_ttQEaUf22IAr1WhAp-3ECmojg_iks5r0derzfJ8OpHssGu1xqFdJBzIum5lw/exec";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}
