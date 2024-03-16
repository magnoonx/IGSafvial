using ArcorpExpress.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;


public static class APIHelper
{
   // public static string JsonData;
    public static async Task<Respuesta> Login(string usuario, string password)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string fileName = "Config/config.txt";
        string filePath = Path.Combine(currentDirectory, fileName);
        int lineNumber = 1;
        string url = File.ReadLines(filePath).Skip(lineNumber - 1).FirstOrDefault();
        try
        {
          //  var url = "http://localhost:5000/api/Usuario/Login";
            using (var client = new HttpClient())
            {
                var data = new { usuario = usuario, password = password };
                var loginmodel = new LoginModel
                {
                    Password = password,
                    UserName = usuario
                };
                string jsonData = JsonConvert.SerializeObject(loginmodel);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");               
                var response = await client.PostAsync(url, content).ConfigureAwait(false);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var Content = await response.Content.ReadAsStringAsync();
                    // var respuesta = JsonConvert.DeserializeObject<Respuesta>(Content);
                    Root? myDeserializedClass = JsonConvert.DeserializeObject<Root>(Content);
                    var token = myDeserializedClass.token;
                    var nombre = myDeserializedClass.user.nombre;
                    var apellido = myDeserializedClass.user.apellido;
                    var IDUsuario = myDeserializedClass.user.iD_Usuario;
                    var perfil = myDeserializedClass.user.perfil;
                    return new Respuesta { success = true, Token = token, Name = nombre, surName = apellido, profile = perfil, iduser = IDUsuario };
                }
                else
                {
                    return new Respuesta { success = false, message = "Login o Contraseña incorrectos, por favor verifique e intente nuevamente" };
                }
            }
        }
        catch (Exception ex)
        {                     
            return new Respuesta { success = false, message = "No se puede conectar con la API" };
        }
    }
    
    // Cuerpo del método para conectar con el TipoVehiculo desde el dashboard
    public static async Task<string> Dash(string Token)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string fileName = "Config/config.txt";
        string filePath = Path.Combine(currentDirectory, fileName);
        int lineNumber = 2;
        string url = File.ReadLines(filePath).Skip(lineNumber - 1).FirstOrDefault();
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string Content = await response.Content.ReadAsStringAsync();                               
                return (Content);                
            }
            else
            {
                return ("No hay conexion, vuelva a intentar");
            }
        }
    }
    // Cuerpo del método para conectar con el Saldo Prepagado
    public static async Task<string> SaldoPrepagado(string Token, string ID_cliente)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string fileName = "Config/configFPago.txt";
        string filePath = Path.Combine(currentDirectory, fileName);
        string url = File.ReadAllText(filePath);
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Content = await response.Content.ReadAsStringAsync();
                List<saldoPrepagado> saldo = JsonConvert.DeserializeObject<List<saldoPrepagado>>(Content);
                saldoPrepagado SaldoCliente = saldo.Find(r => r.iD_Cliente == ID_cliente);
                return SaldoCliente.saldo;
            }
            else
            {
                return ("No hay conexion, vuelva a intentar");
            }
        }
    }

}



public class Respuesta
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public string surName { get; set; }
        public string profile { get; set; }
        public int iduser { get; set; }         
    }



