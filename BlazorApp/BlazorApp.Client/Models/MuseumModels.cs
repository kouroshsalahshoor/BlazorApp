using Newtonsoft.Json;

namespace BlazorApp.Client.Models;

//https://learn.microsoft.com/en-us/visualstudio/ide/reference/paste-json-xml?view=vs-2022

public class MuseumModel
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


public class ArtworkModel
{
    [JsonProperty("total")]
    public int Total { get; set; }
    [JsonProperty("objectIDs")]
    public int[] ObjectIDs { get; set; }
}
