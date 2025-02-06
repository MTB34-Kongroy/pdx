using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://script.google.com/macros/s/AKfycbw2XWnNmncsHiNTJbC1fR3DThV-w86a73jC-7bNj_MwbHl7m9drPCbF16mkJVd7kZHWyw/exec";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}
