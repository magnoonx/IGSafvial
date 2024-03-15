namespace ArcorpExpress.Models
{
    public class LoginModel
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }

    public class Root
    {
        public required string token { get; set; }
        public required User user { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public int rolId { get; set; }
        public int personId { get; set; }
        public required string userName { get; set; }
    }
    public class TokenActual
    {
        public required string token { get; set; }

    }

    public class trfActual
    { 
        public required List<string> id { get; set;}
        public required List<string> nombre { get; set; }
        public required List<string> tarifa { get; set; }
        public required List<string> fechaVigencia { get; set; }
        public required List<string> disabled { get; set; }

    }

}
