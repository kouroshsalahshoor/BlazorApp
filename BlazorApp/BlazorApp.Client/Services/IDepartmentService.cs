using BlazorApp.Client.Models;

namespace BlazorApp.Client.Services;

public interface IDepartmentService
{
    Task<Department[]?> Get();
}