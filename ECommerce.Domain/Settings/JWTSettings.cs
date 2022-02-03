
namespace ECommerce.Domain.Settings
{
    public class JWTSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audienc { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
