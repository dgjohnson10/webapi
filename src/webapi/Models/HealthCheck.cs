namespace webapi;

public class HealthCheck
{
    public string Status { get; set; }

    public HealthCheck()
    {
        Status = "";
    }
}
