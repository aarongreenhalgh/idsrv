using System.Text.Json;

namespace telneva.idsrv.host.Infrastructure.Middleware
{
    public class ErrorDetails
    {
        public string[] Errors { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
