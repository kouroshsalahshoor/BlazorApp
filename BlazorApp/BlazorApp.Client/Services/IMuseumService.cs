using BlazorApp.Client.Models;

namespace BlazorApp.Client.Services;

public interface IMuseumService
{
    Task<Department[]?> GetDepartments();
    Task<List<string>?> GetArtworks(int departmentId);
}