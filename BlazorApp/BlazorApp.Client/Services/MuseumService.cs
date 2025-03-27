using BlazorApp.Client.Models;
using Newtonsoft.Json;

namespace BlazorApp.Client.Services;

//https://metmuseum.github.io/#departments
public class MuseumService : IMuseumService
{
    private readonly HttpClient _httpClient = new();

    public async Task<Department[]?> GetDepartments()
    {
        using HttpResponseMessage response = await _httpClient.GetAsync("https://collectionapi.metmuseum.org/public/collection/v1/departments");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var museumModel = JsonConvert.DeserializeObject<MuseumModel>(content);

        return museumModel?.Departments;
    }

    public async Task<List<string>?> GetArtworks(int departmentId)
    {
        using HttpResponseMessage response = await _httpClient.GetAsync($"https://collectionapi.metmuseum.org/public/collection/v1/objects?departmentIds={departmentId}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var artworkModel = JsonConvert.DeserializeObject<ArtworkModel>(content);

        return artworkModel?.ObjectIDs?.ToList().ConvertAll(x=>x.ToString());
    }
}
