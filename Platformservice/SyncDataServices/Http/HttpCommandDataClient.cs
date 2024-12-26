using System.Text;
using System.Text.Json;
using Platformservice.Dtos;

namespace Platformservice.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;

        public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task SendPlatformToCommand(PlatformReadDto platformReadDto)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(platformReadDto),
                 Encoding.UTF8,
                  "application/json" );

            var response = await _httpClient.PostAsync("http://localhost:6001/api/c/platforms", httpContent);

            if (response.IsSuccessStatusCode) {
                Console.WriteLine("Sync post to command service was OK");

            } else {
                Console.WriteLine("Sync post to command service failed");
            }
        }
    }
}