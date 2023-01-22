namespace GAMMHAClienntApp.Data
{
    public class Employee
    {
        public string? employee_ID { get; set; }
        public string? employee_Name { get; set; }
        public string? employee_Designation { get; set; }
        public string? company_Name { get; set; }
        public Response response { get; set; } = new Response(0, "");
    }
}
