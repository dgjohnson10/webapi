namespace webapi;

public class HealthCheck
{
    public string Status { get; set; }
    public string Message { get; set; }

    public HealthCheck()
    {
        Status = "";
        Message = "";
    }
}
