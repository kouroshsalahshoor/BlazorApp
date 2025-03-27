using Newtonsoft.Json;

namespace BlazorApp.Client.Models;

//https://learn.microsoft.com/en-us/visualstudio/ide/reference/paste-json-xml?view=vs-2022

public class Rootobject
{
    [JsonProperty("departments")]
    public Department[]? Departments { get; set; }
}

public class Department
{
    [JsonProperty("departmentId")]
    public int DepartmentId { get; set; }
    [JsonProperty("displayName")]
    public string? DisplayName { get; set; }
}
