namespace EscolaOnline.Api
{
    public static class Configuration
    {
        //Token - JWT - Json Web Token
        public static string JwtKey = "ZjExYjVjNmItNjg1Zi00OTY1LWFlYmYtZTM4YzAxNWMwNTEx";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "escola_api_IlTvUM/z0ry3NwCV/unWG";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }

    }
}
