namespace ZIPCodePH.Api.Models;

public class ZIPCode
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string? Town { get; set; }
    public string? Area { get; set; }
}