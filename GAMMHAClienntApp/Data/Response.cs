namespace GAMMHAClienntApp.Data
{
    public class Response
    {
        public int Status { get; set; }
        public string? Message { get; set; }

        public Response(int status, string message) { Status = status; Message = message; }
    }
}
