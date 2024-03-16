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
        string url = File.ReadAllText(filePath);
        try
        {
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
                    return new Respuesta { success = true, Token = token, Name = nombre, surName = apellido };
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
        string fileName = "Config/configTarifa.txt";
        string filePath = Path.Combine(currentDirectory, fileName);
        string url = File.ReadAllText(filePath);
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string Content = await response.Content.ReadAsStringAsync();                               
               // List<tfActual> myDeserializedClass = JsonConvert.DeserializeObject<List<tfActual>>(Content);        
               // JsonData = JsonConvert.SerializeObject(myDeserializedClass);
                return (Content);                
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
       
    }



