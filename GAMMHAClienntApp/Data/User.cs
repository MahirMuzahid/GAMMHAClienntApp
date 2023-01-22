namespace GAMMHAClienntApp.Data
{
    public class User
    {
        public string? user_ID { get; set; }
        public string? user_Name { get; set; }
        public string? full_Name { get; set; }
        public string? password { get; set; }
        public byte[]? passwordHash { get; set; }
        public byte[]? passwordSalt { get; set; }
        public string? refreshToken { get; set; } = string.Empty;
        public string? tokenCreated { get; set; }
        public string? tokenExpired { get; set; }
        public Response response { get; set; } = new Response(0, "");
    }
}
