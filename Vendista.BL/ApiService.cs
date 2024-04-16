using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendista.BL.Entityes;
using Vendista.BL.Interfaces;

namespace Vendista.BL;

public class ApiService : IApiService
{
    public const string BASE_URL = "http://178.57.218.210:398";
    public const string TOKEN = "f0d17d3cae184917802e2ef2";

    public async Task<CommandModel> GetCommandTypes()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = $"{BASE_URL}/commands/types?token={TOKEN}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var commandType = JsonConvert.DeserializeObject<CommandModel>(content);
                return commandType;
            }
            else
            {
                return null;
            }
        }
    }
}
