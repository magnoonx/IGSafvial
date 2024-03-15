using Newtonsoft.Json;

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


    public class tarfActual
    {
        public List<long> id { get; set; }
        public List<string> nombre { get; set; }
        public List<string> tarifa { get; set; }
        public List<string> fechaVigencia { get; set; }
        public List<string> disabled { get; set; }

    }

    public class trfActual
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string tarifa { get; set; }
        public string fechaVigencia { get; set; }
        public string disabled { get; set; }


    }

    public class tfActual
    {       
        public string nombre { get; set; }
        public string tarifa { get; set; }
     }
    
}
