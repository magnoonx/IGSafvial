using ArcorpExpress.Models;
using Newtonsoft.Json;
using System.Net;
using System.Text;

public static class APIHelper
{
    public static async Task<Respuesta> Login(string usuario, string password)
    {
        try
        {
            using (var client = new HttpClient())
            {
                var url = "https://localhost/api/User/Login/";
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
                    var respuesta = JsonConvert.DeserializeObject<Respuesta>(Content);
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Content);
                    var token = myDeserializedClass.token;


                    return new Respuesta { success = true };
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
            Console.WriteLine(ex.Message);
        }
    }
}

public class Respuesta
{
    public bool success { get; set; }
    public string message { get; set; }
}
