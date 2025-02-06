using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://script.google.com/macros/s/AKfycbzxYpIgitOAsYxOa0WR_iVVXjdv5S1QDde0aAto4v4jnBfvIC9vBOYEpLDPNhNcg6wcHw/exec";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}
