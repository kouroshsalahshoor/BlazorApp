using BlazorApp.Client.Models;
using Newtonsoft.Json;

namespace BlazorApp.Client.Services;

//https://metmuseum.github.io/#departments
public class DepartmentService : IDepartmentService
{
    private readonly HttpClient _httpClient = new();

    public async Task<Department[]?> Get()
    {
        using HttpResponseMessage response = await _httpClient.GetAsync("https://collectionapi.metmuseum.org/public/collection/v1/departments");
        response.EnsureSuccessStatusCode();

        string? content = await response.Content.ReadAsStringAsync();
        var rootObject = JsonConvert.DeserializeObject<Rootobject>(content);

        return rootObject?.Departments;
    }
}
