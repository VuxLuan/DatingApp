namespace API.Errors;

public class ApiException(int stattusCode, string message, string? details)
{
    public int StattusCode { get; set; } =stattusCode;
    public string Message { get; set; } = message;
    public string? Details { get; set; } = details;
}
