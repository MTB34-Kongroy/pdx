using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://script.google.com/macros/s/AKfycbxsJxv4cGY6vB585nsrVO9-Fc62kEn_Y_l7qDAfqH_SBeBRqob7-ovQoVp3fQzjcSBi4A/exec";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}
