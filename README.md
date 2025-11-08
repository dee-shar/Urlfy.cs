# Urlfy.cs
Web-API for [urlfy.org](https://urlfy.org/) professional URL shortening service for modern businesses

## Example
```cs
using UrlfyApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new Urlfy();
            string url = await api.ShortenUrl("https://google.com");
            Console.WriteLine(url);
        }
    }
}
```
