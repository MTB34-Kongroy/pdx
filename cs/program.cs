using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://script.google.com/macros/s/AKfycbzgKtb2eniMU5Q1gOEowoZAF8O00p8DtHkKoeOm3JjHPAWoAnfzcrFmz86NbO5sLdLSwA/exec";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}
