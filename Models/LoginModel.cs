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
        public int iD_Usuario { get; set; }
        public string perfil { get; set; }
        public string nombre { get; set; }
        public  string apellido { get; set; }
    }

    public class saldoPrepagado
    {
        public string saldo { get; set; }
        public string iD_Cliente { get; set; }
    }




    public class tfActual
    {       
        public string nombre { get; set; }
        public string tarifa { get; set; }
     }
    
}
