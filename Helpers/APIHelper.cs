using ArcorpExpress.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;


public static class APIHelper
{
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
                // var url = "http://192.168.2.13:5000/api/User/Login/";
                
               
                var data = new { usuario = usuario, password = password };
                var loginmodel = new LoginModel

                {
                    Password = password,
                    UserName = usuario
                };
                string jsonData = JsonConvert.SerializeObject(loginmodel);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                // var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json"));
                var response = await client.PostAsync(url, content).ConfigureAwait(false);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var Content = await response.Content.ReadAsStringAsync();
                    // var respuesta = JsonConvert.DeserializeObject<Respuesta>(Content);
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Content);
                    var token = myDeserializedClass.token;                    
                    return new Respuesta { success = true, Token = token };                    
                }
                else
                {
                    return new Respuesta { success = false, message = "Login o Contraseña incorrectos, por favor verifique e intente nuevamente" };
                }
            }
        }
        catch (Exception ex)
        {
            // MessageBox.Show("No se conecta");            
            return new Respuesta { success = false, message = "No se puede conectar con la API" };
            
        }
    }

   


    // Cuerpo del método para obtener la tarifa

    public static async Task<Respuesta> Tarifa(string Token, string Nombre)
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
                trfActual myDeserializedClass = JsonConvert.DeserializeObject<trfActual>(Content); //Convierto la respuesta en un json
                
                string nombreBuscado = Nombre;
                string tarifaCorrespondiente = null;

                if (myDeserializedClass != null && myDeserializedClass.nombre != null)
                {
                    foreach (var nombre in myDeserializedClass.nombre) //busco la tarifa, segun el nombre dado
                    {
                        if (nombre == nombreBuscado)
                        {
                            tarifaCorrespondiente = myDeserializedClass.tarifa.ToString();
                            break; // Al encontrarlo, guardo la tarifa y salgo
                        }
                    }
                }                
                            
                               
                return new Respuesta { success = true, Tarifa = tarifaCorrespondiente };
               
            }
            else
            {
                throw new HttpRequestException("Error al hacer la solicitud: " + response.ReasonPhrase);
            }
        }
    }    
}

public class Respuesta
{
    public bool success { get; set; }
    public string message { get; set; }

    public string Token { get; set; }

    public string Tarifa { get; set; }
}
